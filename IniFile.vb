Imports System.Collections.Generic
Imports System.Linq


''' <summary>
''' This exception is thrown whenever the specified section does not exist.
''' </summary>
Public Class SectionDoesNotExistException
    Inherits Exception

    Private _section As String = String.Empty

    Public Overrides ReadOnly Property Message() As String
        Get
            Return String.Format("The section ""{0}"" does not exist!", _section)
        End Get
    End Property

    Public Sub New(section As String)
        _section = section
    End Sub

End Class

''' <summary>
''' This exception is thrown whenever the specified field inside a section does not exist.
''' </summary>
Public Class FieldDoesNotExistException
    Inherits Exception

    Private _msg As String = String.Empty
    Private _section As String = String.Empty
    Private _field As String = String.Empty

    Public Overrides ReadOnly Property Message() As String
        Get
            Return String.Format("The field ""{0}"" does not exist in the section ""{1}""!", _field, _section)
        End Get
    End Property

    Public Sub New(section As String, field As String)
        _section = section
        _field = field
    End Sub

End Class


''' <summary>
''' This structure contains the INI data read from the file.
''' </summary>
Public Structure Item

    ''' <summary>
    ''' The field name of this item.
    ''' </summary>
    Public Property Field() As String

    ''' <summary>
    ''' The value of the object.
    ''' 
    ''' The type of value will either be:
    ''' 1) String
    ''' 2) Boolean
    ''' 3) Decimal
    ''' </summary>
    Public Property Value() As Object

End Structure

''' <summary>
''' An easy to use, managed class to create, read, write, and modify INI files.
''' </summary>
Public Class Ini

#Region "Properties"

    ''' <summary>
    ''' Internal use, used for making sure sections and their respective items are kept organized.
    ''' </summary>
    Private Property Items() As Dictionary(Of String, List(Of Item))

    ''' <summary>
    ''' Get the different sections in the INI file.
    ''' </summary>
    Public ReadOnly Property Sections() As List(Of String)
        Get
            Return Items.Keys.ToList()
        End Get
    End Property

#End Region

#Region "Initialization and Getter"

    ''' <summary>
    ''' Creates a new INI class.
    ''' </summary>
    Public Sub New()
        Items = New Dictionary(Of String, List(Of Item))()
    End Sub

    ''' <summary>
    ''' A public accessor to retrieve items based on their section
    ''' </summary>
    ''' <param name="name"></param>
    ''' <returns></returns>
    Default Public Property Item(name As String) As List(Of Item)
        Get
            If Not SectionExists(name) Then Add(name)
            Return Items(name)
        End Get
        Set(value As List(Of Item))
            If Not SectionExists(name) Then Add(name)
            Items(name) = value
        End Set
    End Property

#End Region

#Region "Add & Remove"

    ''' <summary>
    ''' Adds a new section to the INI file.
    ''' </summary>
    ''' <param name="section">The name of the section to add.</param>
    Public Sub Add(section As String)
        If Not SectionExists(section) Then
            Items.Add(section, New List(Of Item)())
        End If
    End Sub

    ''' <summary>
    ''' Adds a new field to the INI file.
    ''' </summary>
    ''' <param name="section">The section to add the field under.</param>
    ''' <param name="field">The name of the field.</param>
    ''' <param name="value">The value to add. The value must be either a number, a boolean, or a string.</param>
    Public Sub Add(section As String, field As String, value As Object)
        If Not SectionExists(section) OrElse (FieldExists(section, field)) Then
            Return
        End If
        Me(section).Add(New Item() With { _
                           .Field = field, _
                           .Value = value _
                           })
    End Sub


    ''' <summary>
    ''' Removes a section from the INI file.
    ''' </summary>
    ''' <param name="section">The name of the section to remove.</param>
    Public Sub Remove(section As String)
        If Not SectionExists(section) Then
            Return
        End If
        Items.Remove(section)
    End Sub

    ''' <summary>
    ''' Removes a field from a specified section in the INI file.
    ''' </summary>
    ''' <param name="section">The name of the section to look under.</param>
    ''' <param name="field">The name of the field to remove.</param>
    Public Sub Remove(section As String, field As String)
        If Not SectionExists(section) OrElse Not FieldExists(section, field) Then
            Return
        End If
        Dim itemList As List(Of Item) = Me(section)
        For i As Integer = 0 To itemList.Count - 1
            If itemList(i).Field.Equals(field) Then
                itemList.RemoveAt(i)
            End If
        Next
        Me(section) = itemList
    End Sub

#End Region

#Region "Existance Checking"

    ''' <summary>
    ''' Checks to see if a section exists.
    ''' </summary>
    ''' <param name="section">The name of the section to check.</param>
    ''' <returns>Boolean</returns>
    Private Function SectionExists(section As String) As Boolean
        Return Sections.Where(Function(sectionName) sectionName.Equals(section)).Count().Equals(1)
    End Function

    ''' <summary>
    ''' Checks to see if a field inside of a section exists.
    ''' </summary>
    ''' <param name="section">The name of the section to check under.</param>
    ''' <param name="field">The name of the field to look for.</param>
    ''' <returns>Boolean</returns>
    Private Function FieldExists(section As String, field As String) As Boolean
        Return SectionExists(section) AndAlso Me(section).Where(Function(fieldName) fieldName.Field.Equals(field)).Count().Equals(1)
    End Function

#End Region

#Region "Get"

    ''' <summary>
    ''' Returns the value of a field in the specified section.
    ''' </summary>
    ''' <param name="section">The specified section to look under.</param>
    ''' <param name="field">The field to look for.</param>
    ''' <returns>Object</returns>
    Private Function GetField(section As String, field As String) As Object

        ' LINQ magic.
        If SectionExists(section) AndAlso FieldExists(section, field) Then

            ' Grab the field and return it.

            Return Me(section).Where(Function(fieldName) fieldName.Field.Equals(field)).ToList()(0).Value
        End If

        Throw New SectionDoesNotExistException(section)

    End Function

    ''' <summary>
    ''' Returns the value of a field in the specified section as a boolean
    ''' </summary>
    ''' <param name="section">The specified section to look under.</param>
    ''' <param name="field">The field to look for.</param>
    ''' <returns>Boolean</returns>
    Public Function GetBooleanField(section As String, field As String) As Boolean
        Return Convert.ToBoolean(GetField(section, field))
    End Function

    ''' <summary>
    ''' Returns the value of a field in the specified section as a decimal.
    ''' </summary>
    ''' <param name="section">The specified section to look under.</param>
    ''' <param name="field">The field to look for.</param>
    ''' <returns>Decimal</returns>
    Public Function GetNumberField(section As String, field As String) As Decimal
        Return Convert.ToDecimal(GetField(section, field))
    End Function

    ''' <summary>
    ''' Returns the value of a field in the specified section as a string.
    ''' </summary>
    ''' <param name="section">The specified section to look under.</param>
    ''' <param name="field">The field to look for.</param>
    ''' <returns>String</returns>
    Public Function GetStringField(section As String, field As String) As String
        Return GetField(section, field).ToString()
    End Function

#End Region

#Region "Set"

    ''' <summary>
    ''' Sets the value of the specified field.
    ''' </summary>
    ''' <param name="section">The section to look under.</param>
    ''' <param name="field">The field to look for.</param>
    ''' <param name="value">The value to set.</param>
    Private Sub SetField(section As String, field As String, value As Object)

        ' Check to see that the field and section exists
        If Not SectionExists(section) Then
            Throw New SectionDoesNotExistException(section)
        End If
        If Not FieldExists(section, field) Then
            Throw New FieldDoesNotExistException(section, field)
        End If

        ' Grab the field list
        Dim fieldList As List(Of Item) = Me(section)

        ' Loop
        For i As Integer = 0 To fieldList.Count - 1

            'Is this it? If not, continue.
            If Not fieldList(i).Field.Equals(field) Then
                Continue For
            End If

            ' Grab the field
            Dim fieldData As Item = fieldList(i)
            fieldData.Value = value

            fieldList(i) = fieldData
        Next

        ' Set it back
        Me(section) = fieldList

    End Sub

    ''' <summary>
    ''' Sets the value of the specified field to a boolean value.
    ''' </summary>
    ''' <param name="section">The section to look under.</param>
    ''' <param name="field">The field to look for.</param>
    ''' <param name="value">The value to set.</param>
    Public Sub SetBooleanField(section As String, field As String, value As Boolean)
        SetField(section, field, value)
    End Sub

    ''' <summary>
    ''' Sets the value of the specified field to a numerical value.
    ''' </summary>
    ''' <param name="section">The section to look under.</param>
    ''' <param name="field">The field to look for.</param>
    ''' <param name="value">The value to set.</param>
    Public Sub SetNumberField(section As String, field As String, value As Decimal)
        SetField(section, field, value)
    End Sub

    ''' <summary>
    ''' Sets the value of the specified field to a string value.
    ''' </summary>
    ''' <param name="section">The section to look under.</param>
    ''' <param name="field">The field to look for.</param>
    ''' <param name="value">The value to set.</param>
    Public Sub SetStringField(section As String, field As String, value As String)
        SetField(section, field, value)
    End Sub

#End Region

#Region "Save and Load"

    Public Sub Load(iniFile As String)

        ' Read all the lines in, remove all the blank space.
        Dim rawFileData As String() = IO.File.ReadAllLines(iniFile).Where(Function(line) Not line.Equals(String.Empty) AndAlso Not line.StartsWith(";")).ToArray()

        ' Define a variable for use later.
        Dim currentSection As String = String.Empty

        ' Begin looping data!
        For Each line As String In rawFileData

            ' Check
            If line.StartsWith("[") Then
                currentSection = line.TrimStart("["c).TrimEnd("]"c)
                If Not SectionExists(currentSection) Then
                    Add(currentSection)
                End If
            Else

                ' Take the item and split it.
                Dim lineData As List(Of String) = line.Split("="c).ToList()
                For i As Integer = 0 To lineData.Count() - 1
                    lineData(i) = lineData(i).Trim()
                Next

                ' Try some conversions to store the item as their natural format.
                Dim boolTest As Boolean
                Dim numTest As Decimal

                ' Boolean test
                If [Boolean].TryParse(lineData(1), boolTest) Then
                    Me(currentSection).Add(New Item() With { _
                                              .Field = lineData(0), _
                                              .Value = boolTest _
                                              })

                    ' Move along

                    Continue For
                End If

                ' Number test
                If [Decimal].TryParse(lineData(1), numTest) Then

                    Me(currentSection).Add(New Item() With { _
                                              .Field = lineData(0), _
                                              .Value = numTest _
                                              })

                    ' Move along

                    Continue For
                End If

                ' It's a string, add it and keep going.

                Me(currentSection).Add(New Item() With { _
                                          .Field = lineData(0), _
                                          .Value = lineData(1) _
                                          })

            End If
        Next

    End Sub
    Public Sub Save(iniFile As String)

        ' Okay, create the file stream
        Dim sw As IO.StreamWriter = New IO.StreamWriter(iniFile)

        ' Loop
        For Each section As String In Sections

            ' Start off each section with [sectionName]
            sw.WriteLine(String.Format("[{0}]", section))

            ' Now get items.
            Dim items As List(Of Item) = Me(section)

            ' Loop and write data out.
            For Each item As Item In items
                sw.WriteLine("{0}={1}", item.Field, item.Value)
            Next

            ' Blank gap

            sw.WriteLine()
        Next

        ' All done
        sw.Close()

    End Sub

#End Region

End Class