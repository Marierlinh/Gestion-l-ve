<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("DA")
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Nom")
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Prenom")
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Sexe")
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Ville")
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Nb course reussi")
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Moyenne")
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Statut")
        Me.lblDA = New System.Windows.Forms.Label()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblPrenom = New System.Windows.Forms.Label()
        Me.lblVille = New System.Windows.Forms.Label()
        Me.lblNbcoursReussi = New System.Windows.Forms.Label()
        Me.lblStatut = New System.Windows.Forms.Label()
        Me.lblMoyenne = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.txtPrenom = New System.Windows.Forms.TextBox()
        Me.txtVille = New System.Windows.Forms.TextBox()
        Me.cmdAjouterEleve = New System.Windows.Forms.Button()
        Me.cmdModifierEleve = New System.Windows.Forms.Button()
        Me.cmdSupprimerEleve = New System.Windows.Forms.Button()
        Me.cmdListerEleve = New System.Windows.Forms.Button()
        Me.cmdCalculeMoyenne = New System.Windows.Forms.Button()
        Me.lblSexe = New System.Windows.Forms.Label()
        Me.ComboBoxSexe = New System.Windows.Forms.ComboBox()
        Me.numNbcoursereussi = New System.Windows.Forms.NumericUpDown()
        Me.NumMoyenne = New System.Windows.Forms.NumericUpDown()
        Me.lblGestionEleve = New System.Windows.Forms.Label()
        Me.ComboBoxStatut = New System.Windows.Forms.ComboBox()
        Me.lvEleve = New System.Windows.Forms.ListView()
        Me.cmdPremier = New System.Windows.Forms.Button()
        Me.Precedent = New System.Windows.Forms.Button()
        Me.cmdSuivant = New System.Windows.Forms.Button()
        Me.cmdDernier = New System.Windows.Forms.Button()
        Me.lblEtudiant = New System.Windows.Forms.Label()
        Me.txtDA = New System.Windows.Forms.MaskedTextBox()
        Me.Err1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.numNbcoursereussi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumMoyenne, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Err1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDA
        '
        Me.lblDA.BackColor = System.Drawing.Color.SeaShell
        Me.lblDA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDA.Font = New System.Drawing.Font("Arial Unicode MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDA.ForeColor = System.Drawing.Color.Black
        Me.lblDA.Location = New System.Drawing.Point(74, 112)
        Me.lblDA.Name = "lblDA"
        Me.lblDA.Size = New System.Drawing.Size(160, 29)
        Me.lblDA.TabIndex = 0
        Me.lblDA.Text = "DA :"
        '
        'lblNom
        '
        Me.lblNom.BackColor = System.Drawing.Color.SeaShell
        Me.lblNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNom.Font = New System.Drawing.Font("Arial Unicode MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNom.ForeColor = System.Drawing.Color.Black
        Me.lblNom.Location = New System.Drawing.Point(74, 153)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(160, 29)
        Me.lblNom.TabIndex = 2
        Me.lblNom.Text = "Nom :"
        '
        'lblPrenom
        '
        Me.lblPrenom.BackColor = System.Drawing.Color.SeaShell
        Me.lblPrenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPrenom.Font = New System.Drawing.Font("Arial Unicode MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrenom.ForeColor = System.Drawing.Color.Black
        Me.lblPrenom.Location = New System.Drawing.Point(74, 195)
        Me.lblPrenom.Name = "lblPrenom"
        Me.lblPrenom.Size = New System.Drawing.Size(160, 29)
        Me.lblPrenom.TabIndex = 4
        Me.lblPrenom.Text = "Prenom :"
        '
        'lblVille
        '
        Me.lblVille.BackColor = System.Drawing.Color.SeaShell
        Me.lblVille.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVille.Font = New System.Drawing.Font("Arial Unicode MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVille.ForeColor = System.Drawing.Color.Black
        Me.lblVille.Location = New System.Drawing.Point(74, 280)
        Me.lblVille.Name = "lblVille"
        Me.lblVille.Size = New System.Drawing.Size(160, 29)
        Me.lblVille.TabIndex = 8
        Me.lblVille.Text = "Ville :"
        '
        'lblNbcoursReussi
        '
        Me.lblNbcoursReussi.BackColor = System.Drawing.Color.SeaShell
        Me.lblNbcoursReussi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNbcoursReussi.Font = New System.Drawing.Font("Arial Unicode MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNbcoursReussi.ForeColor = System.Drawing.Color.Black
        Me.lblNbcoursReussi.Location = New System.Drawing.Point(74, 320)
        Me.lblNbcoursReussi.Name = "lblNbcoursReussi"
        Me.lblNbcoursReussi.Size = New System.Drawing.Size(160, 30)
        Me.lblNbcoursReussi.TabIndex = 10
        Me.lblNbcoursReussi.Text = "Nb Cours Reussi :"
        '
        'lblStatut
        '
        Me.lblStatut.BackColor = System.Drawing.Color.SeaShell
        Me.lblStatut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStatut.Font = New System.Drawing.Font("Arial Unicode MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatut.ForeColor = System.Drawing.Color.Black
        Me.lblStatut.Location = New System.Drawing.Point(74, 412)
        Me.lblStatut.Name = "lblStatut"
        Me.lblStatut.Size = New System.Drawing.Size(160, 30)
        Me.lblStatut.TabIndex = 14
        Me.lblStatut.Text = "Statut :"
        '
        'lblMoyenne
        '
        Me.lblMoyenne.BackColor = System.Drawing.Color.SeaShell
        Me.lblMoyenne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMoyenne.Font = New System.Drawing.Font("Arial Unicode MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoyenne.ForeColor = System.Drawing.Color.Black
        Me.lblMoyenne.Location = New System.Drawing.Point(74, 365)
        Me.lblMoyenne.Name = "lblMoyenne"
        Me.lblMoyenne.Size = New System.Drawing.Size(160, 32)
        Me.lblMoyenne.TabIndex = 12
        Me.lblMoyenne.Text = "Moyenne :"
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(264, 151)
        Me.txtNom.MaxLength = 15
        Me.txtNom.Multiline = True
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(171, 29)
        Me.txtNom.TabIndex = 3
        '
        'txtPrenom
        '
        Me.txtPrenom.Location = New System.Drawing.Point(264, 195)
        Me.txtPrenom.MaxLength = 15
        Me.txtPrenom.Multiline = True
        Me.txtPrenom.Name = "txtPrenom"
        Me.txtPrenom.Size = New System.Drawing.Size(171, 29)
        Me.txtPrenom.TabIndex = 5
        '
        'txtVille
        '
        Me.txtVille.Location = New System.Drawing.Point(264, 278)
        Me.txtVille.MaxLength = 20
        Me.txtVille.Multiline = True
        Me.txtVille.Name = "txtVille"
        Me.txtVille.Size = New System.Drawing.Size(233, 29)
        Me.txtVille.TabIndex = 9
        '
        'cmdAjouterEleve
        '
        Me.cmdAjouterEleve.BackColor = System.Drawing.Color.RosyBrown
        Me.cmdAjouterEleve.Font = New System.Drawing.Font("Arial Unicode MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAjouterEleve.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdAjouterEleve.Location = New System.Drawing.Point(642, 112)
        Me.cmdAjouterEleve.Name = "cmdAjouterEleve"
        Me.cmdAjouterEleve.Size = New System.Drawing.Size(138, 49)
        Me.cmdAjouterEleve.TabIndex = 16
        Me.cmdAjouterEleve.Text = "Ajouter Élève"
        Me.cmdAjouterEleve.UseVisualStyleBackColor = False
        '
        'cmdModifierEleve
        '
        Me.cmdModifierEleve.BackColor = System.Drawing.Color.RosyBrown
        Me.cmdModifierEleve.Font = New System.Drawing.Font("Arial Unicode MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdModifierEleve.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdModifierEleve.Location = New System.Drawing.Point(644, 175)
        Me.cmdModifierEleve.Name = "cmdModifierEleve"
        Me.cmdModifierEleve.Size = New System.Drawing.Size(140, 49)
        Me.cmdModifierEleve.TabIndex = 17
        Me.cmdModifierEleve.Text = "Modifier Élève"
        Me.cmdModifierEleve.UseVisualStyleBackColor = False
        '
        'cmdSupprimerEleve
        '
        Me.cmdSupprimerEleve.BackColor = System.Drawing.Color.RosyBrown
        Me.cmdSupprimerEleve.Font = New System.Drawing.Font("Arial Unicode MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSupprimerEleve.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdSupprimerEleve.Location = New System.Drawing.Point(644, 241)
        Me.cmdSupprimerEleve.Name = "cmdSupprimerEleve"
        Me.cmdSupprimerEleve.Size = New System.Drawing.Size(140, 54)
        Me.cmdSupprimerEleve.TabIndex = 18
        Me.cmdSupprimerEleve.Text = "Supprimer Élève"
        Me.cmdSupprimerEleve.UseVisualStyleBackColor = False
        '
        'cmdListerEleve
        '
        Me.cmdListerEleve.BackColor = System.Drawing.Color.RosyBrown
        Me.cmdListerEleve.Font = New System.Drawing.Font("Arial Unicode MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdListerEleve.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdListerEleve.Location = New System.Drawing.Point(642, 481)
        Me.cmdListerEleve.Name = "cmdListerEleve"
        Me.cmdListerEleve.Size = New System.Drawing.Size(140, 49)
        Me.cmdListerEleve.TabIndex = 20
        Me.cmdListerEleve.Text = "Lister Élève"
        Me.cmdListerEleve.UseVisualStyleBackColor = False
        '
        'cmdCalculeMoyenne
        '
        Me.cmdCalculeMoyenne.BackColor = System.Drawing.Color.RosyBrown
        Me.cmdCalculeMoyenne.Font = New System.Drawing.Font("Arial Unicode MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCalculeMoyenne.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdCalculeMoyenne.Location = New System.Drawing.Point(646, 330)
        Me.cmdCalculeMoyenne.Name = "cmdCalculeMoyenne"
        Me.cmdCalculeMoyenne.Size = New System.Drawing.Size(138, 54)
        Me.cmdCalculeMoyenne.TabIndex = 19
        Me.cmdCalculeMoyenne.Text = "Calculer Moyenne"
        Me.cmdCalculeMoyenne.UseVisualStyleBackColor = False
        '
        'lblSexe
        '
        Me.lblSexe.BackColor = System.Drawing.Color.SeaShell
        Me.lblSexe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSexe.Font = New System.Drawing.Font("Arial Unicode MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexe.ForeColor = System.Drawing.Color.Black
        Me.lblSexe.Location = New System.Drawing.Point(74, 238)
        Me.lblSexe.Name = "lblSexe"
        Me.lblSexe.Size = New System.Drawing.Size(160, 29)
        Me.lblSexe.TabIndex = 6
        Me.lblSexe.Text = "Sexe :"
        '
        'ComboBoxSexe
        '
        Me.ComboBoxSexe.FormattingEnabled = True
        Me.ComboBoxSexe.Items.AddRange(New Object() {"F", "M"})
        Me.ComboBoxSexe.Location = New System.Drawing.Point(264, 241)
        Me.ComboBoxSexe.Name = "ComboBoxSexe"
        Me.ComboBoxSexe.Size = New System.Drawing.Size(83, 31)
        Me.ComboBoxSexe.TabIndex = 7
        '
        'numNbcoursereussi
        '
        Me.numNbcoursereussi.Location = New System.Drawing.Point(264, 320)
        Me.numNbcoursereussi.Maximum = New Decimal(New Integer() {25, 0, 0, 0})
        Me.numNbcoursereussi.Name = "numNbcoursereussi"
        Me.numNbcoursereussi.Size = New System.Drawing.Size(141, 30)
        Me.numNbcoursereussi.TabIndex = 11
        '
        'NumMoyenne
        '
        Me.NumMoyenne.DecimalPlaces = 2
        Me.NumMoyenne.Location = New System.Drawing.Point(264, 367)
        Me.NumMoyenne.Name = "NumMoyenne"
        Me.NumMoyenne.Size = New System.Drawing.Size(141, 30)
        Me.NumMoyenne.TabIndex = 13
        '
        'lblGestionEleve
        '
        Me.lblGestionEleve.Font = New System.Drawing.Font("Arial Unicode MS", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGestionEleve.ForeColor = System.Drawing.Color.Sienna
        Me.lblGestionEleve.Location = New System.Drawing.Point(74, 27)
        Me.lblGestionEleve.Name = "lblGestionEleve"
        Me.lblGestionEleve.Size = New System.Drawing.Size(331, 41)
        Me.lblGestionEleve.TabIndex = 27
        Me.lblGestionEleve.Text = "Gestion Élève"
        '
        'ComboBoxStatut
        '
        Me.ComboBoxStatut.FormattingEnabled = True
        Me.ComboBoxStatut.Items.AddRange(New Object() {"A", "I", "X"})
        Me.ComboBoxStatut.Location = New System.Drawing.Point(264, 411)
        Me.ComboBoxStatut.Name = "ComboBoxStatut"
        Me.ComboBoxStatut.Size = New System.Drawing.Size(83, 31)
        Me.ComboBoxStatut.TabIndex = 15
        '
        'lvEleve
        '
        Me.lvEleve.Alignment = System.Windows.Forms.ListViewAlignment.Left
        Me.lvEleve.GridLines = True
        Me.lvEleve.HideSelection = False
        Me.lvEleve.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6, ListViewItem7, ListViewItem8})
        Me.lvEleve.Location = New System.Drawing.Point(47, 572)
        Me.lvEleve.Name = "lvEleve"
        Me.lvEleve.Size = New System.Drawing.Size(746, 260)
        Me.lvEleve.TabIndex = 26
        Me.lvEleve.UseCompatibleStateImageBehavior = False
        Me.lvEleve.View = System.Windows.Forms.View.Details
        '
        'cmdPremier
        '
        Me.cmdPremier.BackColor = System.Drawing.Color.RosyBrown
        Me.cmdPremier.Font = New System.Drawing.Font("Arial Unicode MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPremier.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdPremier.Location = New System.Drawing.Point(74, 494)
        Me.cmdPremier.Name = "cmdPremier"
        Me.cmdPremier.Size = New System.Drawing.Size(56, 36)
        Me.cmdPremier.TabIndex = 21
        Me.cmdPremier.Text = "|<"
        Me.cmdPremier.UseVisualStyleBackColor = False
        '
        'Precedent
        '
        Me.Precedent.BackColor = System.Drawing.Color.RosyBrown
        Me.Precedent.Font = New System.Drawing.Font("Arial Unicode MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Precedent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Precedent.Location = New System.Drawing.Point(136, 494)
        Me.Precedent.Name = "Precedent"
        Me.Precedent.Size = New System.Drawing.Size(56, 36)
        Me.Precedent.TabIndex = 22
        Me.Precedent.Text = "<"
        Me.Precedent.UseVisualStyleBackColor = False
        '
        'cmdSuivant
        '
        Me.cmdSuivant.BackColor = System.Drawing.Color.RosyBrown
        Me.cmdSuivant.Font = New System.Drawing.Font("Arial Unicode MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSuivant.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdSuivant.Location = New System.Drawing.Point(441, 494)
        Me.cmdSuivant.Name = "cmdSuivant"
        Me.cmdSuivant.Size = New System.Drawing.Size(56, 36)
        Me.cmdSuivant.TabIndex = 24
        Me.cmdSuivant.Text = ">"
        Me.cmdSuivant.UseVisualStyleBackColor = False
        '
        'cmdDernier
        '
        Me.cmdDernier.BackColor = System.Drawing.Color.RosyBrown
        Me.cmdDernier.Font = New System.Drawing.Font("Arial Unicode MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDernier.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdDernier.Location = New System.Drawing.Point(503, 494)
        Me.cmdDernier.Name = "cmdDernier"
        Me.cmdDernier.Size = New System.Drawing.Size(56, 36)
        Me.cmdDernier.TabIndex = 25
        Me.cmdDernier.Text = ">|"
        Me.cmdDernier.UseVisualStyleBackColor = False
        '
        'lblEtudiant
        '
        Me.lblEtudiant.BackColor = System.Drawing.Color.LavenderBlush
        Me.lblEtudiant.Location = New System.Drawing.Point(198, 494)
        Me.lblEtudiant.Name = "lblEtudiant"
        Me.lblEtudiant.Size = New System.Drawing.Size(237, 36)
        Me.lblEtudiant.TabIndex = 23
        '
        'txtDA
        '
        Me.txtDA.Location = New System.Drawing.Point(264, 110)
        Me.txtDA.Mask = "0000000"
        Me.txtDA.Name = "txtDA"
        Me.txtDA.Size = New System.Drawing.Size(83, 30)
        Me.txtDA.TabIndex = 1
        Me.txtDA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Err1
        '
        Me.Err1.ContainerControl = Me
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(823, 856)
        Me.Controls.Add(Me.txtDA)
        Me.Controls.Add(Me.lblEtudiant)
        Me.Controls.Add(Me.cmdDernier)
        Me.Controls.Add(Me.cmdSuivant)
        Me.Controls.Add(Me.Precedent)
        Me.Controls.Add(Me.cmdPremier)
        Me.Controls.Add(Me.lvEleve)
        Me.Controls.Add(Me.ComboBoxStatut)
        Me.Controls.Add(Me.lblGestionEleve)
        Me.Controls.Add(Me.NumMoyenne)
        Me.Controls.Add(Me.numNbcoursereussi)
        Me.Controls.Add(Me.ComboBoxSexe)
        Me.Controls.Add(Me.lblSexe)
        Me.Controls.Add(Me.cmdCalculeMoyenne)
        Me.Controls.Add(Me.cmdListerEleve)
        Me.Controls.Add(Me.cmdSupprimerEleve)
        Me.Controls.Add(Me.cmdModifierEleve)
        Me.Controls.Add(Me.cmdAjouterEleve)
        Me.Controls.Add(Me.txtVille)
        Me.Controls.Add(Me.txtPrenom)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.lblMoyenne)
        Me.Controls.Add(Me.lblStatut)
        Me.Controls.Add(Me.lblNbcoursReussi)
        Me.Controls.Add(Me.lblVille)
        Me.Controls.Add(Me.lblPrenom)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.lblDA)
        Me.Font = New System.Drawing.Font("Arial Unicode MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.numNbcoursereussi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumMoyenne, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Err1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDA As Label
    Friend WithEvents lblNom As Label
    Friend WithEvents lblPrenom As Label
    Friend WithEvents lblVille As Label
    Friend WithEvents lblNbcoursReussi As Label
    Friend WithEvents lblStatut As Label
    Friend WithEvents lblMoyenne As Label
    Friend WithEvents txtNom As TextBox
    Friend WithEvents txtPrenom As TextBox
    Friend WithEvents txtVille As TextBox
    Friend WithEvents cmdAjouterEleve As Button
    Friend WithEvents cmdModifierEleve As Button
    Friend WithEvents cmdSupprimerEleve As Button
    Friend WithEvents cmdListerEleve As Button
    Friend WithEvents cmdCalculeMoyenne As Button
    Friend WithEvents lblSexe As Label
    Friend WithEvents ComboBoxSexe As ComboBox
    Friend WithEvents numNbcoursereussi As NumericUpDown
    Friend WithEvents NumMoyenne As NumericUpDown
    Friend WithEvents lblGestionEleve As Label
    Friend WithEvents ComboBoxStatut As ComboBox
    Friend WithEvents cmdPremier As Button
    Friend WithEvents Precedent As Button
    Friend WithEvents cmdSuivant As Button
    Friend WithEvents cmdDernier As Button
    Friend WithEvents lblEtudiant As Label
    Friend WithEvents txtDA As MaskedTextBox
    Friend WithEvents Err1 As ErrorProvider
    Friend WithEvents lvEleve As ListView
End Class
