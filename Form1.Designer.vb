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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.genderLabel = New System.Windows.Forms.Label()
        Me.radioMale = New System.Windows.Forms.RadioButton()
        Me.femaleLabel = New System.Windows.Forms.RadioButton()
        Me.personInfoLabel = New System.Windows.Forms.Label()
        Me.contactLabel = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.addressLabel = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.emailLabel = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.dateLabel = New System.Windows.Forms.Label()
        Me.currentDate = New System.Windows.Forms.DateTimePicker()
        Me.currentTime = New System.Windows.Forms.Label()
        Me.currentTimeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.timerLabel = New System.Windows.Forms.Label()
        Me.locationLabel = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
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
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(506, 122)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(162, 30)
        Me.TextBox1.TabIndex = 7
        Me.TextBox1.TabStop = False
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(781, 122)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(162, 30)
        Me.TextBox2.TabIndex = 8
        Me.TextBox2.TabStop = False
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
        'femaleLabel
        '
        Me.femaleLabel.AutoSize = True
        Me.femaleLabel.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.femaleLabel.Location = New System.Drawing.Point(576, 158)
        Me.femaleLabel.Name = "femaleLabel"
        Me.femaleLabel.Size = New System.Drawing.Size(78, 27)
        Me.femaleLabel.TabIndex = 11
        Me.femaleLabel.Text = "Female"
        Me.femaleLabel.UseVisualStyleBackColor = True
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
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(151, 191)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(227, 30)
        Me.TextBox3.TabIndex = 14
        Me.TextBox3.TabStop = False
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
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(506, 191)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(437, 30)
        Me.TextBox4.TabIndex = 16
        Me.TextBox4.TabStop = False
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
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(151, 227)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(349, 30)
        Me.TextBox5.TabIndex = 18
        Me.TextBox5.TabStop = False
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
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(151, 299)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(349, 30)
        Me.TextBox6.TabIndex = 24
        Me.TextBox6.TabStop = False
        Me.TextBox6.Text = "San Jose del Monte, Bulacan"
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
        Me.firstQuestionLabel.Location = New System.Drawing.Point(231, 377)
        Me.firstQuestionLabel.Name = "firstQuestionLabel"
        Me.firstQuestionLabel.Size = New System.Drawing.Size(514, 27)
        Me.firstQuestionLabel.TabIndex = 26
        Me.firstQuestionLabel.Text = "Have you experienced one of the following symptoms?"
        '
        'firstSymptomLabel
        '
        Me.firstSymptomLabel.AutoSize = True
        Me.firstSymptomLabel.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstSymptomLabel.Location = New System.Drawing.Point(285, 404)
        Me.firstSymptomLabel.Name = "firstSymptomLabel"
        Me.firstSymptomLabel.Size = New System.Drawing.Size(231, 27)
        Me.firstSymptomLabel.TabIndex = 27
        Me.firstSymptomLabel.Text = "Loss of Smell or Taste:"
        '
        'secondSymptomLabel
        '
        Me.secondSymptomLabel.AutoSize = True
        Me.secondSymptomLabel.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.secondSymptomLabel.Location = New System.Drawing.Point(444, 431)
        Me.secondSymptomLabel.Name = "secondSymptomLabel"
        Me.secondSymptomLabel.Size = New System.Drawing.Size(72, 27)
        Me.secondSymptomLabel.TabIndex = 28
        Me.secondSymptomLabel.Text = "Fever:"
        '
        'thirdSymptomLabel
        '
        Me.thirdSymptomLabel.AutoSize = True
        Me.thirdSymptomLabel.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.thirdSymptomLabel.Location = New System.Drawing.Point(443, 458)
        Me.thirdSymptomLabel.Name = "thirdSymptomLabel"
        Me.thirdSymptomLabel.Size = New System.Drawing.Size(73, 27)
        Me.thirdSymptomLabel.TabIndex = 29
        Me.thirdSymptomLabel.Text = "Cough:"
        '
        'fourthSymptomLabel
        '
        Me.fourthSymptomLabel.AutoSize = True
        Me.fourthSymptomLabel.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fourthSymptomLabel.Location = New System.Drawing.Point(383, 485)
        Me.fourthSymptomLabel.Name = "fourthSymptomLabel"
        Me.fourthSymptomLabel.Size = New System.Drawing.Size(134, 27)
        Me.fourthSymptomLabel.TabIndex = 30
        Me.fourthSymptomLabel.Text = "Sore Throat:"
        '
        'fifthSymptomLabel
        '
        Me.fifthSymptomLabel.AutoSize = True
        Me.fifthSymptomLabel.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fifthSymptomLabel.Location = New System.Drawing.Point(449, 512)
        Me.fifthSymptomLabel.Name = "fifthSymptomLabel"
        Me.fifthSymptomLabel.Size = New System.Drawing.Size(67, 27)
        Me.fifthSymptomLabel.TabIndex = 31
        Me.fifthSymptomLabel.Text = "Chills:"
        '
        'firstYesCheckBox
        '
        Me.firstYesCheckBox.AutoSize = True
        Me.firstYesCheckBox.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstYesCheckBox.Location = New System.Drawing.Point(522, 401)
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
        Me.secondYesCheckBox.Location = New System.Drawing.Point(522, 428)
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
        Me.thirdYesCheckBox.Location = New System.Drawing.Point(522, 458)
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
        Me.fourthYesCheckBox.Location = New System.Drawing.Point(522, 485)
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
        Me.fifthYesCheckBox.Location = New System.Drawing.Point(522, 512)
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
        Me.firstNoCheckBox.Location = New System.Drawing.Point(590, 401)
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
        Me.secondNoCheckBox.Location = New System.Drawing.Point(590, 428)
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
        Me.thirdNoCheckBox.Location = New System.Drawing.Point(590, 458)
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
        Me.fourthNoCheckBox.Location = New System.Drawing.Point(590, 485)
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
        Me.fifthNoCheckBox.Location = New System.Drawing.Point(590, 512)
        Me.fifthNoCheckBox.Name = "fifthNoCheckBox"
        Me.fifthNoCheckBox.Size = New System.Drawing.Size(56, 30)
        Me.fifthNoCheckBox.TabIndex = 41
        Me.fifthNoCheckBox.Text = "No"
        Me.fifthNoCheckBox.UseVisualStyleBackColor = True
        '
        'contactTracingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(985, 657)
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
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.locationLabel)
        Me.Controls.Add(Me.timerLabel)
        Me.Controls.Add(Me.currentTime)
        Me.Controls.Add(Me.currentDate)
        Me.Controls.Add(Me.dateLabel)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.emailLabel)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.addressLabel)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.contactLabel)
        Me.Controls.Add(Me.personInfoLabel)
        Me.Controls.Add(Me.femaleLabel)
        Me.Controls.Add(Me.radioMale)
        Me.Controls.Add(Me.genderLabel)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lastNameLabel)
        Me.Controls.Add(Me.midNameLabel)
        Me.Controls.Add(Me.txtboxAge)
        Me.Controls.Add(Me.txtbxFname)
        Me.Controls.Add(Me.ageLabel)
        Me.Controls.Add(Me.firstNameLabel)
        Me.Controls.Add(Me.headerLabel)
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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents genderLabel As Label
    Friend WithEvents radioMale As RadioButton
    Friend WithEvents femaleLabel As RadioButton
    Friend WithEvents personInfoLabel As Label
    Friend WithEvents contactLabel As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents addressLabel As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents emailLabel As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents dateLabel As Label
    Friend WithEvents currentDate As DateTimePicker
    Friend WithEvents currentTime As Label
    Friend WithEvents currentTimeTimer As Timer
    Friend WithEvents timerLabel As Label
    Friend WithEvents locationLabel As Label
    Friend WithEvents TextBox6 As TextBox
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
End Class
