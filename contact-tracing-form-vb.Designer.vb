﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class contactTracingForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.headerLabel = New System.Windows.Forms.Label()
        Me.firstNameLabel = New System.Windows.Forms.Label()
        Me.ageLabel = New System.Windows.Forms.Label()
        Me.txtbxFname = New System.Windows.Forms.TextBox()
        Me.txtboxAge = New System.Windows.Forms.TextBox()
        Me.midNameLabel = New System.Windows.Forms.Label()
        Me.lastNameLabel = New System.Windows.Forms.Label()
        Me.txtbxMidName = New System.Windows.Forms.TextBox()
        Me.txtbxLastName = New System.Windows.Forms.TextBox()
        Me.genderLabel = New System.Windows.Forms.Label()
        Me.radioMale = New System.Windows.Forms.RadioButton()
        Me.radioFemale = New System.Windows.Forms.RadioButton()
        Me.personInfoLabel = New System.Windows.Forms.Label()
        Me.contactLabel = New System.Windows.Forms.Label()
        Me.txtbxContact = New System.Windows.Forms.TextBox()
        Me.addressLabel = New System.Windows.Forms.Label()
        Me.txtbxAddress = New System.Windows.Forms.TextBox()
        Me.emailLabel = New System.Windows.Forms.Label()
        Me.txtbxEmail = New System.Windows.Forms.TextBox()
        Me.dateLabel = New System.Windows.Forms.Label()
        Me.currentDate = New System.Windows.Forms.DateTimePicker()
        Me.currentTime = New System.Windows.Forms.Label()
        Me.currentTimeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.timerLabel = New System.Windows.Forms.Label()
        Me.locationLabel = New System.Windows.Forms.Label()
        Me.txtbxLocation = New System.Windows.Forms.TextBox()
        Me.checkListLabel = New System.Windows.Forms.Label()
        Me.firstQuestionLabel = New System.Windows.Forms.Label()
        Me.firstSymptomLabel = New System.Windows.Forms.Label()
        Me.secondSymptomLabel = New System.Windows.Forms.Label()
        Me.thirdSymptomLabel = New System.Windows.Forms.Label()
        Me.fourthSymptomLabel = New System.Windows.Forms.Label()
        Me.fifthSymptomLabel = New System.Windows.Forms.Label()
        Me.firstYesCheckBox = New System.Windows.Forms.CheckBox()
        Me.secondYesCheckBox = New System.Windows.Forms.CheckBox()
        Me.thirdYesCheckBox = New System.Windows.Forms.CheckBox()
        Me.fourthYesCheckBox = New System.Windows.Forms.CheckBox()
        Me.fifthYesCheckBox = New System.Windows.Forms.CheckBox()
        Me.firstNoCheckBox = New System.Windows.Forms.CheckBox()
        Me.secondNoCheckBox = New System.Windows.Forms.CheckBox()
        Me.thirdNoCheckBox = New System.Windows.Forms.CheckBox()
        Me.fourthNoCheckBox = New System.Windows.Forms.CheckBox()
        Me.fifthNoCheckBox = New System.Windows.Forms.CheckBox()
        Me.secondQuestionLabel = New System.Windows.Forms.Label()
        Me.travelYesCheckBox = New System.Windows.Forms.CheckBox()
        Me.travelNoCheckBox = New System.Windows.Forms.CheckBox()
        Me.thirdQuestionLabel1 = New System.Windows.Forms.Label()
        Me.thirdQuestionLabel2 = New System.Windows.Forms.Label()
        Me.inContactYesCheckBox = New System.Windows.Forms.CheckBox()
        Me.inContactNoCheckBox = New System.Windows.Forms.CheckBox()
        Me.lbl_warning = New System.Windows.Forms.Label()
        Me.submitFormButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'headerLabel
        '
        Me.headerLabel.AutoSize = True
        Me.headerLabel.Font = New System.Drawing.Font("Comic Sans MS", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.headerLabel.Location = New System.Drawing.Point(215, 25)
        Me.headerLabel.Name = "headerLabel"
        Me.headerLabel.Size = New System.Drawing.Size(547, 45)
        Me.headerLabel.TabIndex = 0
        Me.headerLabel.Text = "OCPC CONTACT TRACING FORM"
        '
        'firstNameLabel
        '
        Me.firstNameLabel.AutoSize = True
        Me.firstNameLabel.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstNameLabel.Location = New System.Drawing.Point(40, 125)
        Me.firstNameLabel.Name = "firstNameLabel"
        Me.firstNameLabel.Size = New System.Drawing.Size(105, 23)
        Me.firstNameLabel.TabIndex = 1
        Me.firstNameLabel.Text = "First Name:"
        '
        'ageLabel
        '
        Me.ageLabel.AutoSize = True
        Me.ageLabel.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ageLabel.Location = New System.Drawing.Point(98, 160)
        Me.ageLabel.Name = "ageLabel"
        Me.ageLabel.Size = New System.Drawing.Size(47, 23)
        Me.ageLabel.TabIndex = 2
        Me.ageLabel.Text = "Age:"
        '
        'txtbxFname
        '
        Me.txtbxFname.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxFname.Location = New System.Drawing.Point(151, 122)
        Me.txtbxFname.Name = "txtbxFname"
        Me.txtbxFname.Size = New System.Drawing.Size(227, 30)
        Me.txtbxFname.TabIndex = 3
        Me.txtbxFname.TabStop = False
        '
        'txtboxAge
        '
        Me.txtboxAge.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxAge.Location = New System.Drawing.Point(151, 157)
        Me.txtboxAge.Name = "txtboxAge"
        Me.txtboxAge.Size = New System.Drawing.Size(76, 30)
        Me.txtboxAge.TabIndex = 4
        Me.txtboxAge.TabStop = False
        '
        'midNameLabel
        '
        Me.midNameLabel.AutoSize = True
        Me.midNameLabel.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.midNameLabel.Location = New System.Drawing.Point(384, 125)
        Me.midNameLabel.Name = "midNameLabel"
        Me.midNameLabel.Size = New System.Drawing.Size(116, 23)
        Me.midNameLabel.TabIndex = 5
        Me.midNameLabel.Text = "Middle Name:"
        '
        'lastNameLabel
        '
        Me.lastNameLabel.AutoSize = True
        Me.lastNameLabel.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastNameLabel.Location = New System.Drawing.Point(674, 125)
        Me.lastNameLabel.Name = "lastNameLabel"
        Me.lastNameLabel.Size = New System.Drawing.Size(101, 23)
        Me.lastNameLabel.TabIndex = 6
        Me.lastNameLabel.Text = "Last Name:"
        '
        'txtbxMidName
        '
        Me.txtbxMidName.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxMidName.Location = New System.Drawing.Point(506, 122)
        Me.txtbxMidName.Name = "txtbxMidName"
        Me.txtbxMidName.Size = New System.Drawing.Size(162, 30)
        Me.txtbxMidName.TabIndex = 7
        Me.txtbxMidName.TabStop = False
        '
        'txtbxLastName
        '
        Me.txtbxLastName.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxLastName.Location = New System.Drawing.Point(781, 122)
        Me.txtbxLastName.Name = "txtbxLastName"
        Me.txtbxLastName.Size = New System.Drawing.Size(162, 30)
        Me.txtbxLastName.TabIndex = 8
        Me.txtbxLastName.TabStop = False
        '
        'genderLabel
        '
        Me.genderLabel.AutoSize = True
        Me.genderLabel.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.genderLabel.Location = New System.Drawing.Point(429, 160)
        Me.genderLabel.Name = "genderLabel"
        Me.genderLabel.Size = New System.Drawing.Size(71, 23)
        Me.genderLabel.TabIndex = 9
        Me.genderLabel.Text = "Gender:"
        '
        'radioMale
        '
        Me.radioMale.AutoSize = True
        Me.radioMale.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioMale.Location = New System.Drawing.Point(506, 158)
        Me.radioMale.Name = "radioMale"
        Me.radioMale.Size = New System.Drawing.Size(64, 27)
        Me.radioMale.TabIndex = 10
        Me.radioMale.Text = "Male"
        Me.radioMale.UseVisualStyleBackColor = True
        '
        'radioFemale
        '
        Me.radioFemale.AutoSize = True
        Me.radioFemale.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioFemale.Location = New System.Drawing.Point(576, 158)
        Me.radioFemale.Name = "radioFemale"
        Me.radioFemale.Size = New System.Drawing.Size(78, 27)
        Me.radioFemale.TabIndex = 11
        Me.radioFemale.Text = "Female"
        Me.radioFemale.UseVisualStyleBackColor = True
        '
        'personInfoLabel
        '
        Me.personInfoLabel.AutoSize = True
        Me.personInfoLabel.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.personInfoLabel.Location = New System.Drawing.Point(12, 85)
        Me.personInfoLabel.Name = "personInfoLabel"
        Me.personInfoLabel.Size = New System.Drawing.Size(260, 34)
        Me.personInfoLabel.TabIndex = 12
        Me.personInfoLabel.Text = "Personal Information"
        '
        'contactLabel
        '
        Me.contactLabel.AutoSize = True
        Me.contactLabel.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contactLabel.Location = New System.Drawing.Point(2, 194)
        Me.contactLabel.Name = "contactLabel"
        Me.contactLabel.Size = New System.Drawing.Size(143, 23)
        Me.contactLabel.TabIndex = 13
        Me.contactLabel.Text = "Contact Number:"
        '
        'txtbxContact
        '
        Me.txtbxContact.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxContact.Location = New System.Drawing.Point(151, 191)
        Me.txtbxContact.Name = "txtbxContact"
        Me.txtbxContact.Size = New System.Drawing.Size(227, 30)
        Me.txtbxContact.TabIndex = 14
        Me.txtbxContact.TabStop = False
        '
        'addressLabel
        '
        Me.addressLabel.AutoSize = True
        Me.addressLabel.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addressLabel.Location = New System.Drawing.Point(420, 194)
        Me.addressLabel.Name = "addressLabel"
        Me.addressLabel.Size = New System.Drawing.Size(80, 23)
        Me.addressLabel.TabIndex = 15
        Me.addressLabel.Text = "Address:"
        '
        'txtbxAddress
        '
        Me.txtbxAddress.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxAddress.Location = New System.Drawing.Point(506, 191)
        Me.txtbxAddress.Name = "txtbxAddress"
        Me.txtbxAddress.Size = New System.Drawing.Size(437, 30)
        Me.txtbxAddress.TabIndex = 16
        Me.txtbxAddress.TabStop = False
        '
        'emailLabel
        '
        Me.emailLabel.AutoSize = True
        Me.emailLabel.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailLabel.Location = New System.Drawing.Point(19, 230)
        Me.emailLabel.Name = "emailLabel"
        Me.emailLabel.Size = New System.Drawing.Size(126, 23)
        Me.emailLabel.TabIndex = 17
        Me.emailLabel.Text = "Email Address:"
        '
        'txtbxEmail
        '
        Me.txtbxEmail.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxEmail.Location = New System.Drawing.Point(151, 227)
        Me.txtbxEmail.Name = "txtbxEmail"
        Me.txtbxEmail.Size = New System.Drawing.Size(349, 30)
        Me.txtbxEmail.TabIndex = 18
        Me.txtbxEmail.TabStop = False
        '
        'dateLabel
        '
        Me.dateLabel.AutoSize = True
        Me.dateLabel.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateLabel.Location = New System.Drawing.Point(90, 269)
        Me.dateLabel.Name = "dateLabel"
        Me.dateLabel.Size = New System.Drawing.Size(55, 23)
        Me.dateLabel.TabIndex = 19
        Me.dateLabel.Text = "Date:"
        '
        'currentDate
        '
        Me.currentDate.CalendarFont = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currentDate.CustomFormat = "MM/dd/yyyy"
        Me.currentDate.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currentDate.Location = New System.Drawing.Point(151, 263)
        Me.currentDate.Name = "currentDate"
        Me.currentDate.Size = New System.Drawing.Size(282, 30)
        Me.currentDate.TabIndex = 20
        Me.currentDate.TabStop = False
        '
        'currentTime
        '
        Me.currentTime.AutoSize = True
        Me.currentTime.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currentTime.Location = New System.Drawing.Point(445, 269)
        Me.currentTime.Name = "currentTime"
        Me.currentTime.Size = New System.Drawing.Size(53, 23)
        Me.currentTime.TabIndex = 21
        Me.currentTime.Text = "Time:"
        '
        'currentTimeTimer
        '
        Me.currentTimeTimer.Enabled = True
        Me.currentTimeTimer.Interval = 1
        '
        'timerLabel
        '
        Me.timerLabel.AutoSize = True
        Me.timerLabel.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timerLabel.Location = New System.Drawing.Point(502, 269)
        Me.timerLabel.Name = "timerLabel"
        Me.timerLabel.Size = New System.Drawing.Size(0, 23)
        Me.timerLabel.TabIndex = 22
        '
        'locationLabel
        '
        Me.locationLabel.AutoSize = True
        Me.locationLabel.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.locationLabel.Location = New System.Drawing.Point(66, 302)
        Me.locationLabel.Name = "locationLabel"
        Me.locationLabel.Size = New System.Drawing.Size(79, 23)
        Me.locationLabel.TabIndex = 23
        Me.locationLabel.Text = "Location:"
        '
        'txtbxLocation
        '
        Me.txtbxLocation.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxLocation.Location = New System.Drawing.Point(151, 299)
        Me.txtbxLocation.Name = "txtbxLocation"
        Me.txtbxLocation.Size = New System.Drawing.Size(349, 30)
        Me.txtbxLocation.TabIndex = 24
        Me.txtbxLocation.TabStop = False
        Me.txtbxLocation.Text = "San Jose del Monte, Bulacan"
        '
        'checkListLabel
        '
        Me.checkListLabel.AutoSize = True
        Me.checkListLabel.Font = New System.Drawing.Font("Comic Sans MS", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkListLabel.Location = New System.Drawing.Point(282, 332)
        Me.checkListLabel.Name = "checkListLabel"
        Me.checkListLabel.Size = New System.Drawing.Size(429, 45)
        Me.checkListLabel.TabIndex = 25
        Me.checkListLabel.Text = "Health Condition Checklist"
        '
        'firstQuestionLabel
        '
        Me.firstQuestionLabel.AutoSize = True
        Me.firstQuestionLabel.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstQuestionLabel.Location = New System.Drawing.Point(218, 377)
        Me.firstQuestionLabel.Name = "firstQuestionLabel"
        Me.firstQuestionLabel.Size = New System.Drawing.Size(542, 27)
        Me.firstQuestionLabel.TabIndex = 26
        Me.firstQuestionLabel.Text = "1. Have you experienced one of the following symptoms?"
        '
        'firstSymptomLabel
        '
        Me.firstSymptomLabel.AutoSize = True
        Me.firstSymptomLabel.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstSymptomLabel.Location = New System.Drawing.Point(285, 410)
        Me.firstSymptomLabel.Name = "firstSymptomLabel"
        Me.firstSymptomLabel.Size = New System.Drawing.Size(231, 27)
        Me.firstSymptomLabel.TabIndex = 27
        Me.firstSymptomLabel.Text = "Loss of Smell or Taste:"
        '
        'secondSymptomLabel
        '
        Me.secondSymptomLabel.AutoSize = True
        Me.secondSymptomLabel.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.secondSymptomLabel.Location = New System.Drawing.Point(444, 437)
        Me.secondSymptomLabel.Name = "secondSymptomLabel"
        Me.secondSymptomLabel.Size = New System.Drawing.Size(72, 27)
        Me.secondSymptomLabel.TabIndex = 28
        Me.secondSymptomLabel.Text = "Fever:"
        '
        'thirdSymptomLabel
        '
        Me.thirdSymptomLabel.AutoSize = True
        Me.thirdSymptomLabel.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.thirdSymptomLabel.Location = New System.Drawing.Point(443, 464)
        Me.thirdSymptomLabel.Name = "thirdSymptomLabel"
        Me.thirdSymptomLabel.Size = New System.Drawing.Size(73, 27)
        Me.thirdSymptomLabel.TabIndex = 29
        Me.thirdSymptomLabel.Text = "Cough:"
        '
        'fourthSymptomLabel
        '
        Me.fourthSymptomLabel.AutoSize = True
        Me.fourthSymptomLabel.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fourthSymptomLabel.Location = New System.Drawing.Point(383, 491)
        Me.fourthSymptomLabel.Name = "fourthSymptomLabel"
        Me.fourthSymptomLabel.Size = New System.Drawing.Size(134, 27)
        Me.fourthSymptomLabel.TabIndex = 30
        Me.fourthSymptomLabel.Text = "Sore Throat:"
        '
        'fifthSymptomLabel
        '
        Me.fifthSymptomLabel.AutoSize = True
        Me.fifthSymptomLabel.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fifthSymptomLabel.Location = New System.Drawing.Point(449, 518)
        Me.fifthSymptomLabel.Name = "fifthSymptomLabel"
        Me.fifthSymptomLabel.Size = New System.Drawing.Size(67, 27)
        Me.fifthSymptomLabel.TabIndex = 31
        Me.fifthSymptomLabel.Text = "Chills:"
        '
        'firstYesCheckBox
        '
        Me.firstYesCheckBox.AutoSize = True
        Me.firstYesCheckBox.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstYesCheckBox.Location = New System.Drawing.Point(522, 407)
        Me.firstYesCheckBox.Name = "firstYesCheckBox"
        Me.firstYesCheckBox.Size = New System.Drawing.Size(62, 30)
        Me.firstYesCheckBox.TabIndex = 32
        Me.firstYesCheckBox.Text = "Yes"
        Me.firstYesCheckBox.UseVisualStyleBackColor = True
        '
        'secondYesCheckBox
        '
        Me.secondYesCheckBox.AutoSize = True
        Me.secondYesCheckBox.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.secondYesCheckBox.Location = New System.Drawing.Point(522, 434)
        Me.secondYesCheckBox.Name = "secondYesCheckBox"
        Me.secondYesCheckBox.Size = New System.Drawing.Size(62, 30)
        Me.secondYesCheckBox.TabIndex = 33
        Me.secondYesCheckBox.Text = "Yes"
        Me.secondYesCheckBox.UseVisualStyleBackColor = True
        '
        'thirdYesCheckBox
        '
        Me.thirdYesCheckBox.AutoSize = True
        Me.thirdYesCheckBox.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.thirdYesCheckBox.Location = New System.Drawing.Point(522, 464)
        Me.thirdYesCheckBox.Name = "thirdYesCheckBox"
        Me.thirdYesCheckBox.Size = New System.Drawing.Size(62, 30)
        Me.thirdYesCheckBox.TabIndex = 34
        Me.thirdYesCheckBox.Text = "Yes"
        Me.thirdYesCheckBox.UseVisualStyleBackColor = True
        '
        'fourthYesCheckBox
        '
        Me.fourthYesCheckBox.AutoSize = True
        Me.fourthYesCheckBox.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fourthYesCheckBox.Location = New System.Drawing.Point(522, 491)
        Me.fourthYesCheckBox.Name = "fourthYesCheckBox"
        Me.fourthYesCheckBox.Size = New System.Drawing.Size(62, 30)
        Me.fourthYesCheckBox.TabIndex = 35
        Me.fourthYesCheckBox.Text = "Yes"
        Me.fourthYesCheckBox.UseVisualStyleBackColor = True
        '
        'fifthYesCheckBox
        '
        Me.fifthYesCheckBox.AutoSize = True
        Me.fifthYesCheckBox.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fifthYesCheckBox.Location = New System.Drawing.Point(522, 518)
        Me.fifthYesCheckBox.Name = "fifthYesCheckBox"
        Me.fifthYesCheckBox.Size = New System.Drawing.Size(62, 30)
        Me.fifthYesCheckBox.TabIndex = 36
        Me.fifthYesCheckBox.Text = "Yes"
        Me.fifthYesCheckBox.UseVisualStyleBackColor = True
        '
        'firstNoCheckBox
        '
        Me.firstNoCheckBox.AutoSize = True
        Me.firstNoCheckBox.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstNoCheckBox.Location = New System.Drawing.Point(590, 407)
        Me.firstNoCheckBox.Name = "firstNoCheckBox"
        Me.firstNoCheckBox.Size = New System.Drawing.Size(56, 30)
        Me.firstNoCheckBox.TabIndex = 37
        Me.firstNoCheckBox.Text = "No"
        Me.firstNoCheckBox.UseVisualStyleBackColor = True
        '
        'secondNoCheckBox
        '
        Me.secondNoCheckBox.AutoSize = True
        Me.secondNoCheckBox.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.secondNoCheckBox.Location = New System.Drawing.Point(590, 434)
        Me.secondNoCheckBox.Name = "secondNoCheckBox"
        Me.secondNoCheckBox.Size = New System.Drawing.Size(56, 30)
        Me.secondNoCheckBox.TabIndex = 38
        Me.secondNoCheckBox.Text = "No"
        Me.secondNoCheckBox.UseVisualStyleBackColor = True
        '
        'thirdNoCheckBox
        '
        Me.thirdNoCheckBox.AutoSize = True
        Me.thirdNoCheckBox.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.thirdNoCheckBox.Location = New System.Drawing.Point(590, 464)
        Me.thirdNoCheckBox.Name = "thirdNoCheckBox"
        Me.thirdNoCheckBox.Size = New System.Drawing.Size(56, 30)
        Me.thirdNoCheckBox.TabIndex = 39
        Me.thirdNoCheckBox.Text = "No"
        Me.thirdNoCheckBox.UseVisualStyleBackColor = True
        '
        'fourthNoCheckBox
        '
        Me.fourthNoCheckBox.AutoSize = True
        Me.fourthNoCheckBox.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fourthNoCheckBox.Location = New System.Drawing.Point(590, 491)
        Me.fourthNoCheckBox.Name = "fourthNoCheckBox"
        Me.fourthNoCheckBox.Size = New System.Drawing.Size(56, 30)
        Me.fourthNoCheckBox.TabIndex = 40
        Me.fourthNoCheckBox.Text = "No"
        Me.fourthNoCheckBox.UseVisualStyleBackColor = True
        '
        'fifthNoCheckBox
        '
        Me.fifthNoCheckBox.AutoSize = True
        Me.fifthNoCheckBox.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fifthNoCheckBox.Location = New System.Drawing.Point(590, 518)
        Me.fifthNoCheckBox.Name = "fifthNoCheckBox"
        Me.fifthNoCheckBox.Size = New System.Drawing.Size(56, 30)
        Me.fifthNoCheckBox.TabIndex = 41
        Me.fifthNoCheckBox.Text = "No"
        Me.fifthNoCheckBox.UseVisualStyleBackColor = True
        '
        'secondQuestionLabel
        '
        Me.secondQuestionLabel.AutoSize = True
        Me.secondQuestionLabel.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.secondQuestionLabel.Location = New System.Drawing.Point(18, 551)
        Me.secondQuestionLabel.Name = "secondQuestionLabel"
        Me.secondQuestionLabel.Size = New System.Drawing.Size(807, 27)
        Me.secondQuestionLabel.TabIndex = 42
        Me.secondQuestionLabel.Text = "2. Have you traveled outside the Philippines anytime from December 2019 until now" &
    "?"
        '
        'travelYesCheckBox
        '
        Me.travelYesCheckBox.AutoSize = True
        Me.travelYesCheckBox.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.travelYesCheckBox.Location = New System.Drawing.Point(824, 551)
        Me.travelYesCheckBox.Name = "travelYesCheckBox"
        Me.travelYesCheckBox.Size = New System.Drawing.Size(62, 30)
        Me.travelYesCheckBox.TabIndex = 43
        Me.travelYesCheckBox.Text = "Yes"
        Me.travelYesCheckBox.UseVisualStyleBackColor = True
        '
        'travelNoCheckBox
        '
        Me.travelNoCheckBox.AutoSize = True
        Me.travelNoCheckBox.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.travelNoCheckBox.Location = New System.Drawing.Point(887, 551)
        Me.travelNoCheckBox.Name = "travelNoCheckBox"
        Me.travelNoCheckBox.Size = New System.Drawing.Size(56, 30)
        Me.travelNoCheckBox.TabIndex = 44
        Me.travelNoCheckBox.Text = "No"
        Me.travelNoCheckBox.UseVisualStyleBackColor = True
        '
        'thirdQuestionLabel1
        '
        Me.thirdQuestionLabel1.AutoSize = True
        Me.thirdQuestionLabel1.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.thirdQuestionLabel1.Location = New System.Drawing.Point(18, 584)
        Me.thirdQuestionLabel1.Name = "thirdQuestionLabel1"
        Me.thirdQuestionLabel1.Size = New System.Drawing.Size(887, 27)
        Me.thirdQuestionLabel1.TabIndex = 45
        Me.thirdQuestionLabel1.Text = "3. Have you, or anyone you have been in close contact with been diagnosed with CO" &
    "VID-19, "
        '
        'thirdQuestionLabel2
        '
        Me.thirdQuestionLabel2.AutoSize = True
        Me.thirdQuestionLabel2.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.thirdQuestionLabel2.Location = New System.Drawing.Point(45, 617)
        Me.thirdQuestionLabel2.Name = "thirdQuestionLabel2"
        Me.thirdQuestionLabel2.Size = New System.Drawing.Size(637, 27)
        Me.thirdQuestionLabel2.TabIndex = 46
        Me.thirdQuestionLabel2.Text = "or been placed on quarantine for possible contact with COVID-19?"
        '
        'inContactYesCheckBox
        '
        Me.inContactYesCheckBox.AutoSize = True
        Me.inContactYesCheckBox.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inContactYesCheckBox.Location = New System.Drawing.Point(688, 617)
        Me.inContactYesCheckBox.Name = "inContactYesCheckBox"
        Me.inContactYesCheckBox.Size = New System.Drawing.Size(62, 30)
        Me.inContactYesCheckBox.TabIndex = 47
        Me.inContactYesCheckBox.Text = "Yes"
        Me.inContactYesCheckBox.UseVisualStyleBackColor = True
        '
        'inContactNoCheckBox
        '
        Me.inContactNoCheckBox.AutoSize = True
        Me.inContactNoCheckBox.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inContactNoCheckBox.Location = New System.Drawing.Point(756, 617)
        Me.inContactNoCheckBox.Name = "inContactNoCheckBox"
        Me.inContactNoCheckBox.Size = New System.Drawing.Size(56, 30)
        Me.inContactNoCheckBox.TabIndex = 48
        Me.inContactNoCheckBox.Text = "No"
        Me.inContactNoCheckBox.UseVisualStyleBackColor = True
        '
        'lbl_warning
        '
        Me.lbl_warning.AutoSize = True
        Me.lbl_warning.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_warning.Location = New System.Drawing.Point(29, 691)
        Me.lbl_warning.Name = "lbl_warning"
        Me.lbl_warning.Size = New System.Drawing.Size(932, 19)
        Me.lbl_warning.TabIndex = 49
        Me.lbl_warning.Text = "If you reply YES to any of the questions in the checklist, stay home and contact " &
    "a health care provider for guidance and assistance."
        '
        'submitFormButton
        '
        Me.submitFormButton.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submitFormButton.Location = New System.Drawing.Point(433, 647)
        Me.submitFormButton.Name = "submitFormButton"
        Me.submitFormButton.Size = New System.Drawing.Size(93, 41)
        Me.submitFormButton.TabIndex = 50
        Me.submitFormButton.Text = "Submit"
        Me.submitFormButton.UseVisualStyleBackColor = True
        '
        'contactTracingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(985, 717)
        Me.Controls.Add(Me.submitFormButton)
        Me.Controls.Add(Me.lbl_warning)
        Me.Controls.Add(Me.inContactNoCheckBox)
        Me.Controls.Add(Me.inContactYesCheckBox)
        Me.Controls.Add(Me.thirdQuestionLabel2)
        Me.Controls.Add(Me.thirdQuestionLabel1)
        Me.Controls.Add(Me.travelNoCheckBox)
        Me.Controls.Add(Me.travelYesCheckBox)
        Me.Controls.Add(Me.secondQuestionLabel)
        Me.Controls.Add(Me.fifthNoCheckBox)
        Me.Controls.Add(Me.fourthNoCheckBox)
        Me.Controls.Add(Me.thirdNoCheckBox)
        Me.Controls.Add(Me.secondNoCheckBox)
        Me.Controls.Add(Me.firstNoCheckBox)
        Me.Controls.Add(Me.fifthYesCheckBox)
        Me.Controls.Add(Me.fourthYesCheckBox)
        Me.Controls.Add(Me.thirdYesCheckBox)
        Me.Controls.Add(Me.secondYesCheckBox)
        Me.Controls.Add(Me.firstYesCheckBox)
        Me.Controls.Add(Me.fifthSymptomLabel)
        Me.Controls.Add(Me.fourthSymptomLabel)
        Me.Controls.Add(Me.thirdSymptomLabel)
        Me.Controls.Add(Me.secondSymptomLabel)
        Me.Controls.Add(Me.firstSymptomLabel)
        Me.Controls.Add(Me.firstQuestionLabel)
        Me.Controls.Add(Me.checkListLabel)
        Me.Controls.Add(Me.txtbxLocation)
        Me.Controls.Add(Me.locationLabel)
        Me.Controls.Add(Me.timerLabel)
        Me.Controls.Add(Me.currentTime)
        Me.Controls.Add(Me.currentDate)
        Me.Controls.Add(Me.dateLabel)
        Me.Controls.Add(Me.txtbxEmail)
        Me.Controls.Add(Me.emailLabel)
        Me.Controls.Add(Me.txtbxAddress)
        Me.Controls.Add(Me.addressLabel)
        Me.Controls.Add(Me.txtbxContact)
        Me.Controls.Add(Me.contactLabel)
        Me.Controls.Add(Me.personInfoLabel)
        Me.Controls.Add(Me.radioFemale)
        Me.Controls.Add(Me.radioMale)
        Me.Controls.Add(Me.genderLabel)
        Me.Controls.Add(Me.txtbxLastName)
        Me.Controls.Add(Me.txtbxMidName)
        Me.Controls.Add(Me.lastNameLabel)
        Me.Controls.Add(Me.midNameLabel)
        Me.Controls.Add(Me.txtboxAge)
        Me.Controls.Add(Me.txtbxFname)
        Me.Controls.Add(Me.ageLabel)
        Me.Controls.Add(Me.firstNameLabel)
        Me.Controls.Add(Me.headerLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "contactTracingForm"
        Me.Text = "Contact Tracing Form VB"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents headerLabel As Label
    Friend WithEvents firstNameLabel As Label
    Friend WithEvents ageLabel As Label
    Friend WithEvents txtbxFname As TextBox
    Friend WithEvents txtboxAge As TextBox
    Friend WithEvents midNameLabel As Label
    Friend WithEvents lastNameLabel As Label
    Friend WithEvents txtbxMidName As TextBox
    Friend WithEvents txtbxLastName As TextBox
    Friend WithEvents genderLabel As Label
    Friend WithEvents radioMale As RadioButton
    Friend WithEvents radioFemale As RadioButton
    Friend WithEvents personInfoLabel As Label
    Friend WithEvents contactLabel As Label
    Friend WithEvents txtbxContact As TextBox
    Friend WithEvents addressLabel As Label
    Friend WithEvents txtbxAddress As TextBox
    Friend WithEvents emailLabel As Label
    Friend WithEvents txtbxEmail As TextBox
    Friend WithEvents dateLabel As Label
    Friend WithEvents currentDate As DateTimePicker
    Friend WithEvents currentTime As Label
    Friend WithEvents currentTimeTimer As Timer
    Friend WithEvents timerLabel As Label
    Friend WithEvents locationLabel As Label
    Friend WithEvents txtbxLocation As TextBox
    Friend WithEvents checkListLabel As Label
    Friend WithEvents firstQuestionLabel As Label
    Friend WithEvents firstSymptomLabel As Label
    Friend WithEvents secondSymptomLabel As Label
    Friend WithEvents thirdSymptomLabel As Label
    Friend WithEvents fourthSymptomLabel As Label
    Friend WithEvents fifthSymptomLabel As Label
    Friend WithEvents firstYesCheckBox As CheckBox
    Friend WithEvents secondYesCheckBox As CheckBox
    Friend WithEvents thirdYesCheckBox As CheckBox
    Friend WithEvents fourthYesCheckBox As CheckBox
    Friend WithEvents fifthYesCheckBox As CheckBox
    Friend WithEvents firstNoCheckBox As CheckBox
    Friend WithEvents secondNoCheckBox As CheckBox
    Friend WithEvents thirdNoCheckBox As CheckBox
    Friend WithEvents fourthNoCheckBox As CheckBox
    Friend WithEvents fifthNoCheckBox As CheckBox
    Friend WithEvents secondQuestionLabel As Label
    Friend WithEvents travelYesCheckBox As CheckBox
    Friend WithEvents travelNoCheckBox As CheckBox
    Private WithEvents thirdQuestionLabel1 As Label
    Private WithEvents thirdQuestionLabel2 As Label
    Friend WithEvents inContactYesCheckBox As CheckBox
    Friend WithEvents inContactNoCheckBox As CheckBox
    Private WithEvents lbl_warning As Label
    Friend WithEvents submitFormButton As Button
End Class
