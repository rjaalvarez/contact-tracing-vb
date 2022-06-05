<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.fourthSymptomLabel = New System.Windows.Forms.Label()
        Me.fifthSymptomLabel = New System.Windows.Forms.Label()
        Me.secondQuestionLabel = New System.Windows.Forms.Label()
        Me.thirdQuestionLabel1 = New System.Windows.Forms.Label()
        Me.thirdQuestionLabel2 = New System.Windows.Forms.Label()
        Me.footerLabel = New System.Windows.Forms.Label()
        Me.submitFormButton = New System.Windows.Forms.Button()
        Me.firstGroupBox = New System.Windows.Forms.GroupBox()
        Me.firstNoRadio = New System.Windows.Forms.RadioButton()
        Me.firstYesRadio = New System.Windows.Forms.RadioButton()
        Me.secondGroupBox = New System.Windows.Forms.GroupBox()
        Me.secondNoRadio = New System.Windows.Forms.RadioButton()
        Me.secondYesRadio = New System.Windows.Forms.RadioButton()
        Me.thirdNoRadio = New System.Windows.Forms.RadioButton()
        Me.fourthGroupBox = New System.Windows.Forms.GroupBox()
        Me.fourthNoRadio = New System.Windows.Forms.RadioButton()
        Me.fourthYesRadio = New System.Windows.Forms.RadioButton()
        Me.thirdGroupBox = New System.Windows.Forms.GroupBox()
        Me.thirdYesRadio = New System.Windows.Forms.RadioButton()
        Me.thirdSymptomLabel = New System.Windows.Forms.Label()
        Me.fifthGroupBox = New System.Windows.Forms.GroupBox()
        Me.fifthNoRadio = New System.Windows.Forms.RadioButton()
        Me.fifthYesRadio = New System.Windows.Forms.RadioButton()
        Me.travelGroupBox = New System.Windows.Forms.GroupBox()
        Me.travelNoRadio = New System.Windows.Forms.RadioButton()
        Me.travelYesRadio = New System.Windows.Forms.RadioButton()
        Me.inContactGroupBox = New System.Windows.Forms.GroupBox()
        Me.inContactNoRadio = New System.Windows.Forms.RadioButton()
        Me.inContactYesRadio = New System.Windows.Forms.RadioButton()
        Me.firstGroupBox.SuspendLayout()
        Me.secondGroupBox.SuspendLayout()
        Me.fourthGroupBox.SuspendLayout()
        Me.thirdGroupBox.SuspendLayout()
        Me.fifthGroupBox.SuspendLayout()
        Me.travelGroupBox.SuspendLayout()
        Me.inContactGroupBox.SuspendLayout()
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
        Me.firstSymptomLabel.Location = New System.Drawing.Point(6, 16)
        Me.firstSymptomLabel.Name = "firstSymptomLabel"
        Me.firstSymptomLabel.Size = New System.Drawing.Size(231, 27)
        Me.firstSymptomLabel.TabIndex = 27
        Me.firstSymptomLabel.Text = "Loss of Smell or Taste:"
        '
        'secondSymptomLabel
        '
        Me.secondSymptomLabel.AutoSize = True
        Me.secondSymptomLabel.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.secondSymptomLabel.Location = New System.Drawing.Point(167, 16)
        Me.secondSymptomLabel.Name = "secondSymptomLabel"
        Me.secondSymptomLabel.Size = New System.Drawing.Size(72, 27)
        Me.secondSymptomLabel.TabIndex = 28
        Me.secondSymptomLabel.Text = "Fever:"
        '
        'fourthSymptomLabel
        '
        Me.fourthSymptomLabel.AutoSize = True
        Me.fourthSymptomLabel.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fourthSymptomLabel.Location = New System.Drawing.Point(4, 16)
        Me.fourthSymptomLabel.Name = "fourthSymptomLabel"
        Me.fourthSymptomLabel.Size = New System.Drawing.Size(134, 27)
        Me.fourthSymptomLabel.TabIndex = 30
        Me.fourthSymptomLabel.Text = "Sore Throat:"
        '
        'fifthSymptomLabel
        '
        Me.fifthSymptomLabel.AutoSize = True
        Me.fifthSymptomLabel.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fifthSymptomLabel.Location = New System.Drawing.Point(71, 16)
        Me.fifthSymptomLabel.Name = "fifthSymptomLabel"
        Me.fifthSymptomLabel.Size = New System.Drawing.Size(67, 27)
        Me.fifthSymptomLabel.TabIndex = 31
        Me.fifthSymptomLabel.Text = "Chills:"
        '
        'secondQuestionLabel
        '
        Me.secondQuestionLabel.AutoSize = True
        Me.secondQuestionLabel.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.secondQuestionLabel.Location = New System.Drawing.Point(16, 18)
        Me.secondQuestionLabel.Name = "secondQuestionLabel"
        Me.secondQuestionLabel.Size = New System.Drawing.Size(807, 27)
        Me.secondQuestionLabel.TabIndex = 42
        Me.secondQuestionLabel.Text = "2. Have you traveled outside the Philippines anytime from December 2019 until now" &
    "?"
        '
        'thirdQuestionLabel1
        '
        Me.thirdQuestionLabel1.AutoSize = True
        Me.thirdQuestionLabel1.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.thirdQuestionLabel1.Location = New System.Drawing.Point(16, 10)
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
        Me.thirdQuestionLabel2.Location = New System.Drawing.Point(43, 41)
        Me.thirdQuestionLabel2.Name = "thirdQuestionLabel2"
        Me.thirdQuestionLabel2.Size = New System.Drawing.Size(637, 27)
        Me.thirdQuestionLabel2.TabIndex = 46
        Me.thirdQuestionLabel2.Text = "or been placed on quarantine for possible contact with COVID-19?"
        '
        'footerLabel
        '
        Me.footerLabel.AutoSize = True
        Me.footerLabel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.footerLabel.Location = New System.Drawing.Point(29, 712)
        Me.footerLabel.Name = "footerLabel"
        Me.footerLabel.Size = New System.Drawing.Size(932, 19)
        Me.footerLabel.TabIndex = 49
        Me.footerLabel.Text = "If you reply YES to any of the questions in the checklist, stay home and contact " &
    "a health care provider for guidance and assistance."
        '
        'submitFormButton
        '
        Me.submitFormButton.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submitFormButton.Location = New System.Drawing.Point(433, 668)
        Me.submitFormButton.Name = "submitFormButton"
        Me.submitFormButton.Size = New System.Drawing.Size(93, 41)
        Me.submitFormButton.TabIndex = 50
        Me.submitFormButton.Text = "Submit"
        Me.submitFormButton.UseVisualStyleBackColor = True
        '
        'firstGroupBox
        '
        Me.firstGroupBox.Controls.Add(Me.firstNoRadio)
        Me.firstGroupBox.Controls.Add(Me.firstYesRadio)
        Me.firstGroupBox.Controls.Add(Me.firstSymptomLabel)
        Me.firstGroupBox.Location = New System.Drawing.Point(33, 407)
        Me.firstGroupBox.Name = "firstGroupBox"
        Me.firstGroupBox.Size = New System.Drawing.Size(360, 57)
        Me.firstGroupBox.TabIndex = 51
        Me.firstGroupBox.TabStop = False
        '
        'firstNoRadio
        '
        Me.firstNoRadio.AutoSize = True
        Me.firstNoRadio.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstNoRadio.Location = New System.Drawing.Point(300, 17)
        Me.firstNoRadio.Name = "firstNoRadio"
        Me.firstNoRadio.Size = New System.Drawing.Size(55, 30)
        Me.firstNoRadio.TabIndex = 53
        Me.firstNoRadio.Text = "No"
        Me.firstNoRadio.UseVisualStyleBackColor = True
        '
        'firstYesRadio
        '
        Me.firstYesRadio.AutoSize = True
        Me.firstYesRadio.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstYesRadio.Location = New System.Drawing.Point(243, 17)
        Me.firstYesRadio.Name = "firstYesRadio"
        Me.firstYesRadio.Size = New System.Drawing.Size(61, 30)
        Me.firstYesRadio.TabIndex = 52
        Me.firstYesRadio.Text = "Yes"
        Me.firstYesRadio.UseVisualStyleBackColor = True
        '
        'secondGroupBox
        '
        Me.secondGroupBox.Controls.Add(Me.secondNoRadio)
        Me.secondGroupBox.Controls.Add(Me.secondYesRadio)
        Me.secondGroupBox.Controls.Add(Me.secondSymptomLabel)
        Me.secondGroupBox.Location = New System.Drawing.Point(33, 470)
        Me.secondGroupBox.Name = "secondGroupBox"
        Me.secondGroupBox.Size = New System.Drawing.Size(360, 57)
        Me.secondGroupBox.TabIndex = 54
        Me.secondGroupBox.TabStop = False
        '
        'secondNoRadio
        '
        Me.secondNoRadio.AutoSize = True
        Me.secondNoRadio.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.secondNoRadio.Location = New System.Drawing.Point(300, 17)
        Me.secondNoRadio.Name = "secondNoRadio"
        Me.secondNoRadio.Size = New System.Drawing.Size(55, 30)
        Me.secondNoRadio.TabIndex = 53
        Me.secondNoRadio.Text = "No"
        Me.secondNoRadio.UseVisualStyleBackColor = True
        '
        'secondYesRadio
        '
        Me.secondYesRadio.AutoSize = True
        Me.secondYesRadio.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.secondYesRadio.Location = New System.Drawing.Point(243, 17)
        Me.secondYesRadio.Name = "secondYesRadio"
        Me.secondYesRadio.Size = New System.Drawing.Size(61, 30)
        Me.secondYesRadio.TabIndex = 52
        Me.secondYesRadio.Text = "Yes"
        Me.secondYesRadio.UseVisualStyleBackColor = True
        '
        'thirdNoRadio
        '
        Me.thirdNoRadio.AutoSize = True
        Me.thirdNoRadio.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.thirdNoRadio.Location = New System.Drawing.Point(211, 17)
        Me.thirdNoRadio.Name = "thirdNoRadio"
        Me.thirdNoRadio.Size = New System.Drawing.Size(55, 30)
        Me.thirdNoRadio.TabIndex = 53
        Me.thirdNoRadio.Text = "No"
        Me.thirdNoRadio.UseVisualStyleBackColor = True
        '
        'fourthGroupBox
        '
        Me.fourthGroupBox.Controls.Add(Me.fourthNoRadio)
        Me.fourthGroupBox.Controls.Add(Me.fourthYesRadio)
        Me.fourthGroupBox.Controls.Add(Me.fourthSymptomLabel)
        Me.fourthGroupBox.Location = New System.Drawing.Point(399, 470)
        Me.fourthGroupBox.Name = "fourthGroupBox"
        Me.fourthGroupBox.Size = New System.Drawing.Size(275, 57)
        Me.fourthGroupBox.TabIndex = 55
        Me.fourthGroupBox.TabStop = False
        '
        'fourthNoRadio
        '
        Me.fourthNoRadio.AutoSize = True
        Me.fourthNoRadio.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fourthNoRadio.Location = New System.Drawing.Point(211, 15)
        Me.fourthNoRadio.Name = "fourthNoRadio"
        Me.fourthNoRadio.Size = New System.Drawing.Size(55, 30)
        Me.fourthNoRadio.TabIndex = 53
        Me.fourthNoRadio.Text = "No"
        Me.fourthNoRadio.UseVisualStyleBackColor = True
        '
        'fourthYesRadio
        '
        Me.fourthYesRadio.AutoSize = True
        Me.fourthYesRadio.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fourthYesRadio.Location = New System.Drawing.Point(144, 15)
        Me.fourthYesRadio.Name = "fourthYesRadio"
        Me.fourthYesRadio.Size = New System.Drawing.Size(61, 30)
        Me.fourthYesRadio.TabIndex = 52
        Me.fourthYesRadio.Text = "Yes"
        Me.fourthYesRadio.UseVisualStyleBackColor = True
        '
        'thirdGroupBox
        '
        Me.thirdGroupBox.Controls.Add(Me.thirdNoRadio)
        Me.thirdGroupBox.Controls.Add(Me.thirdYesRadio)
        Me.thirdGroupBox.Controls.Add(Me.thirdSymptomLabel)
        Me.thirdGroupBox.Location = New System.Drawing.Point(399, 407)
        Me.thirdGroupBox.Name = "thirdGroupBox"
        Me.thirdGroupBox.Size = New System.Drawing.Size(275, 57)
        Me.thirdGroupBox.TabIndex = 54
        Me.thirdGroupBox.TabStop = False
        '
        'thirdYesRadio
        '
        Me.thirdYesRadio.AutoSize = True
        Me.thirdYesRadio.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.thirdYesRadio.Location = New System.Drawing.Point(144, 17)
        Me.thirdYesRadio.Name = "thirdYesRadio"
        Me.thirdYesRadio.Size = New System.Drawing.Size(61, 30)
        Me.thirdYesRadio.TabIndex = 52
        Me.thirdYesRadio.Text = "Yes"
        Me.thirdYesRadio.UseVisualStyleBackColor = True
        '
        'thirdSymptomLabel
        '
        Me.thirdSymptomLabel.AutoSize = True
        Me.thirdSymptomLabel.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.thirdSymptomLabel.Location = New System.Drawing.Point(65, 16)
        Me.thirdSymptomLabel.Name = "thirdSymptomLabel"
        Me.thirdSymptomLabel.Size = New System.Drawing.Size(73, 27)
        Me.thirdSymptomLabel.TabIndex = 29
        Me.thirdSymptomLabel.Text = "Cough:"
        '
        'fifthGroupBox
        '
        Me.fifthGroupBox.Controls.Add(Me.fifthNoRadio)
        Me.fifthGroupBox.Controls.Add(Me.fifthYesRadio)
        Me.fifthGroupBox.Controls.Add(Me.fifthSymptomLabel)
        Me.fifthGroupBox.Location = New System.Drawing.Point(680, 407)
        Me.fifthGroupBox.Name = "fifthGroupBox"
        Me.fifthGroupBox.Size = New System.Drawing.Size(275, 57)
        Me.fifthGroupBox.TabIndex = 55
        Me.fifthGroupBox.TabStop = False
        '
        'fifthNoRadio
        '
        Me.fifthNoRadio.AutoSize = True
        Me.fifthNoRadio.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fifthNoRadio.Location = New System.Drawing.Point(211, 17)
        Me.fifthNoRadio.Name = "fifthNoRadio"
        Me.fifthNoRadio.Size = New System.Drawing.Size(55, 30)
        Me.fifthNoRadio.TabIndex = 53
        Me.fifthNoRadio.Text = "No"
        Me.fifthNoRadio.UseVisualStyleBackColor = True
        '
        'fifthYesRadio
        '
        Me.fifthYesRadio.AutoSize = True
        Me.fifthYesRadio.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fifthYesRadio.Location = New System.Drawing.Point(144, 17)
        Me.fifthYesRadio.Name = "fifthYesRadio"
        Me.fifthYesRadio.Size = New System.Drawing.Size(61, 30)
        Me.fifthYesRadio.TabIndex = 52
        Me.fifthYesRadio.Text = "Yes"
        Me.fifthYesRadio.UseVisualStyleBackColor = True
        '
        'travelGroupBox
        '
        Me.travelGroupBox.Controls.Add(Me.travelNoRadio)
        Me.travelGroupBox.Controls.Add(Me.travelYesRadio)
        Me.travelGroupBox.Controls.Add(Me.secondQuestionLabel)
        Me.travelGroupBox.Location = New System.Drawing.Point(6, 533)
        Me.travelGroupBox.Name = "travelGroupBox"
        Me.travelGroupBox.Size = New System.Drawing.Size(949, 57)
        Me.travelGroupBox.TabIndex = 54
        Me.travelGroupBox.TabStop = False
        '
        'travelNoRadio
        '
        Me.travelNoRadio.AutoSize = True
        Me.travelNoRadio.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.travelNoRadio.Location = New System.Drawing.Point(888, 17)
        Me.travelNoRadio.Name = "travelNoRadio"
        Me.travelNoRadio.Size = New System.Drawing.Size(55, 30)
        Me.travelNoRadio.TabIndex = 53
        Me.travelNoRadio.Text = "No"
        Me.travelNoRadio.UseVisualStyleBackColor = True
        '
        'travelYesRadio
        '
        Me.travelYesRadio.AutoSize = True
        Me.travelYesRadio.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.travelYesRadio.Location = New System.Drawing.Point(829, 17)
        Me.travelYesRadio.Name = "travelYesRadio"
        Me.travelYesRadio.Size = New System.Drawing.Size(61, 30)
        Me.travelYesRadio.TabIndex = 52
        Me.travelYesRadio.Text = "Yes"
        Me.travelYesRadio.UseVisualStyleBackColor = True
        '
        'inContactGroupBox
        '
        Me.inContactGroupBox.Controls.Add(Me.inContactNoRadio)
        Me.inContactGroupBox.Controls.Add(Me.inContactYesRadio)
        Me.inContactGroupBox.Controls.Add(Me.thirdQuestionLabel1)
        Me.inContactGroupBox.Controls.Add(Me.thirdQuestionLabel2)
        Me.inContactGroupBox.Location = New System.Drawing.Point(6, 589)
        Me.inContactGroupBox.Name = "inContactGroupBox"
        Me.inContactGroupBox.Size = New System.Drawing.Size(949, 73)
        Me.inContactGroupBox.TabIndex = 55
        Me.inContactGroupBox.TabStop = False
        '
        'inContactNoRadio
        '
        Me.inContactNoRadio.AutoSize = True
        Me.inContactNoRadio.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inContactNoRadio.Location = New System.Drawing.Point(888, 41)
        Me.inContactNoRadio.Name = "inContactNoRadio"
        Me.inContactNoRadio.Size = New System.Drawing.Size(55, 30)
        Me.inContactNoRadio.TabIndex = 53
        Me.inContactNoRadio.Text = "No"
        Me.inContactNoRadio.UseVisualStyleBackColor = True
        '
        'inContactYesRadio
        '
        Me.inContactYesRadio.AutoSize = True
        Me.inContactYesRadio.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inContactYesRadio.Location = New System.Drawing.Point(829, 41)
        Me.inContactYesRadio.Name = "inContactYesRadio"
        Me.inContactYesRadio.Size = New System.Drawing.Size(61, 30)
        Me.inContactYesRadio.TabIndex = 52
        Me.inContactYesRadio.Text = "Yes"
        Me.inContactYesRadio.UseVisualStyleBackColor = True
        '
        'contactTracingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(985, 740)
        Me.Controls.Add(Me.inContactGroupBox)
        Me.Controls.Add(Me.travelGroupBox)
        Me.Controls.Add(Me.fifthGroupBox)
        Me.Controls.Add(Me.thirdGroupBox)
        Me.Controls.Add(Me.fourthGroupBox)
        Me.Controls.Add(Me.secondGroupBox)
        Me.Controls.Add(Me.firstGroupBox)
        Me.Controls.Add(Me.submitFormButton)
        Me.Controls.Add(Me.footerLabel)
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
        Me.firstGroupBox.ResumeLayout(False)
        Me.firstGroupBox.PerformLayout()
        Me.secondGroupBox.ResumeLayout(False)
        Me.secondGroupBox.PerformLayout()
        Me.fourthGroupBox.ResumeLayout(False)
        Me.fourthGroupBox.PerformLayout()
        Me.thirdGroupBox.ResumeLayout(False)
        Me.thirdGroupBox.PerformLayout()
        Me.fifthGroupBox.ResumeLayout(False)
        Me.fifthGroupBox.PerformLayout()
        Me.travelGroupBox.ResumeLayout(False)
        Me.travelGroupBox.PerformLayout()
        Me.inContactGroupBox.ResumeLayout(False)
        Me.inContactGroupBox.PerformLayout()
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
    Friend WithEvents fourthSymptomLabel As Label
    Friend WithEvents fifthSymptomLabel As Label
    Friend WithEvents secondQuestionLabel As Label
    Private WithEvents thirdQuestionLabel1 As Label
    Private WithEvents thirdQuestionLabel2 As Label
    Private WithEvents footerLabel As Label
    Friend WithEvents submitFormButton As Button
    Friend WithEvents firstGroupBox As GroupBox
    Friend WithEvents firstNoRadio As RadioButton
    Friend WithEvents firstYesRadio As RadioButton
    Friend WithEvents secondGroupBox As GroupBox
    Friend WithEvents secondNoRadio As RadioButton
    Friend WithEvents secondYesRadio As RadioButton
    Friend WithEvents thirdNoRadio As RadioButton
    Friend WithEvents fourthGroupBox As GroupBox
    Friend WithEvents fourthNoRadio As RadioButton
    Friend WithEvents fourthYesRadio As RadioButton
    Friend WithEvents thirdGroupBox As GroupBox
    Friend WithEvents thirdYesRadio As RadioButton
    Friend WithEvents thirdSymptomLabel As Label
    Friend WithEvents fifthGroupBox As GroupBox
    Friend WithEvents fifthNoRadio As RadioButton
    Friend WithEvents fifthYesRadio As RadioButton
    Friend WithEvents travelGroupBox As GroupBox
    Friend WithEvents travelNoRadio As RadioButton
    Friend WithEvents travelYesRadio As RadioButton
    Friend WithEvents inContactGroupBox As GroupBox
    Friend WithEvents inContactNoRadio As RadioButton
    Friend WithEvents inContactYesRadio As RadioButton
End Class
