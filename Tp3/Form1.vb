Public Class Form1

#Region "Variables"

    Dim ListeE As New Eleve
    Dim No_E As Integer = 0

#End Region

#Region "Bouttons deplacement"

    Private Sub cmdPremier_Click(sender As Object, e As EventArgs) Handles cmdPremier.Click
        Dim etu As Etudiant
        No_E = 0
        etu = ListeE.Etudiants(No_E)
        txtDA.Text = etu.DA
        txtNom.Text = etu.Nom
        txtPrenom.Text = etu.Prenom
        ComboBoxSexe.Text = etu.Sexe
        txtVille.Text = etu.Ville
        numNbcoursereussi.Value = etu.NbCoursReussi
        NumMoyenne.Value = etu.Moyenne
        ComboBoxStatut.Text = etu.Statut

        txtDA.Enabled = False

    End Sub

    Private Sub Precedent_Click(sender As Object, e As EventArgs) Handles Precedent.Click
        Dim etu As Etudiant
        No_E -= 1
        etu = ListeE.Etudiants(No_E)
        txtDA.Text = etu.DA
        txtNom.Text = etu.Nom
        txtPrenom.Text = etu.Prenom
        ComboBoxSexe.Text = etu.Sexe
        txtVille.Text = etu.Ville
        numNbcoursereussi.Value = etu.NbCoursReussi
        NumMoyenne.Value = etu.Moyenne
        ComboBoxStatut.Text = etu.Statut

        txtDA.Enabled = False
    End Sub

    Private Sub cmdSuivant_Click(sender As Object, e As EventArgs) Handles cmdSuivant.Click
        Dim etu As Etudiant
        No_E += 1
        etu = ListeE.Etudiants(No_E)
        txtDA.Text = etu.DA
        txtNom.Text = etu.Nom
        txtPrenom.Text = etu.Prenom
        ComboBoxSexe.Text = etu.Sexe
        txtVille.Text = etu.Ville
        numNbcoursereussi.Value = etu.NbCoursReussi
        NumMoyenne.Value = etu.Moyenne
        ComboBoxStatut.Text = etu.Statut

        txtDA.Enabled = False
    End Sub

    Private Sub cmdDernier_Click(sender As Object, e As EventArgs) Handles cmdDernier.Click
        Dim etu As Etudiant
        No_E = Eleve._Nb_Etu.Count
        etu = ListeE.Etudiants(No_E - 1)
        txtDA.Text = etu.DA
        txtNom.Text = etu.Nom
        txtPrenom.Text = etu.Prenom
        ComboBoxSexe.Text = etu.Sexe
        txtVille.Text = etu.Ville
        numNbcoursereussi.Value = etu.NbCoursReussi
        NumMoyenne.Value = etu.Moyenne
        ComboBoxStatut.Text = etu.Statut

        txtDA.Enabled = False
    End Sub

#End Region

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Function ValiderFormulaire() As Boolean
        Dim valide As Boolean = False

        Err1.Clear()

        If (Not txtDA.MaskCompleted) Then
            valide = False
            Err1.SetError(txtDA, "Entrée invalide,  le DA est obligatoire")
        ElseIf (txtNom.Text = "") Then
            valide = False
            Err1.SetError(txtNom, "Entrée invalide,  le Nom est obligatoire")
        ElseIf (txtPrenom.Text = "") Then
            valide = False
            Err1.SetError(txtPrenom, "Entrée invalide,  le Prenom est obligatoire")
        ElseIf (ComboBoxSexe.Text = "") Then
            valide = False
            Err1.SetError(ComboBoxSexe, "Entrée invalide,  le Sexe est obligatoire")
        ElseIf (txtVille.Text = "") Then
            valide = False
            Err1.SetError(txtVille, "Entrée invalide,  le Ville est obligatoire")
        ElseIf (numNbcoursereussi.Value = 0) Then
            valide = False
            Err1.SetError(numNbcoursereussi, "Entrée invalide,  le Nb course reussi est obligatoire")
        ElseIf (NumMoyenne.Value = 0) Then
            valide = False
            Err1.SetError(NumMoyenne, "Entrée invalide,  le Moyenne est obligatoire")
        ElseIf (ComboBoxStatut.Text = "") Then
            valide = False
            Err1.SetError(ComboBoxStatut, "Entrée invalide,  le Statut est obligatoire")
        Else
            valide = True
        End If
        Return valide
    End Function

    Private Sub Validation_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNom.KeyPress, txtPrenom.KeyPress, txtVille.KeyPress

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo texto", MsgBoxStyle.Exclamation, "Ingreso de Texto")
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If


    End Sub

#Region "Bouttons"
    Private Sub cmdAjouterEleve_Click(sender As Object, e As EventArgs) Handles cmdAjouterEleve.Click
        Dim DA, Nom, Prenom, Ville As String
        Dim Sexe, Statut As Char
        Dim NbCoursReussi As Integer
        Dim Moyenne As Single


        If ValiderFormulaire() = True Then
            DA = txtDA.Text
            Nom = txtNom.Text
            Prenom = txtPrenom.Text
            Sexe = ComboBoxSexe.Text
            Ville = txtVille.Text
            NbCoursReussi = numNbcoursereussi.Value
            Moyenne = NumMoyenne.Value
            Statut = ComboBoxStatut.Text

            ListeE.Ajouter(DA, Nom, Prenom, Sexe, Ville, NbCoursReussi, Moyenne, Statut)
            txtDA.Text = ""
            txtNom.Text = ""
            txtPrenom.Text = ""
            ComboBoxSexe.Text = ""
            txtVille.Text = ""
            numNbcoursereussi.Value = 0
            NumMoyenne.Value = 0
            ComboBoxStatut.Text = ""
        End If

    End Sub


    Private Sub cmdModifierEleve_Click(sender As Object, e As EventArgs) Handles cmdModifierEleve.Click
        Dim DA, Nom, Prenom, Ville As String
        Dim Sexe, Statut As Char
        Dim NbCoursReussi As Integer
        Dim Moyenne As Single
        If ValiderFormulaire() = True Then
            DA = txtDA.Text
            Nom = txtNom.Text
            Prenom = txtPrenom.Text
            Sexe = ComboBoxSexe.Text
            Ville = txtVille.Text
            NbCoursReussi = numNbcoursereussi.Value
            Moyenne = NumMoyenne.Value
            Statut = ComboBoxStatut.Text

            ListeE.Modifier(DA, Nom, Prenom, Sexe, Ville, NbCoursReussi, Moyenne, Statut, No_E)
            txtDA.Text = ""
            txtNom.Text = ""
            txtPrenom.Text = ""
            ComboBoxSexe.Text = ""
            txtVille.Text = ""
            numNbcoursereussi.Value = 0
            NumMoyenne.Value = 0
            ComboBoxStatut.Text = ""
        End If


    End Sub

    Private Sub cmdSupprimerEleve_Click(sender As Object, e As EventArgs) Handles cmdSupprimerEleve.Click
        If (Not txtDA.MaskCompleted) And txtNom.Text = "" And txtPrenom.Text = "" And ComboBoxSexe.Text = "" _
            And txtVille.Text = "" And numNbcoursereussi.Value = 0 And NumMoyenne.Value = 0 And ComboBoxStatut.Text = "" Then
            MsgBox("Vous n'avez pas sélectionné aucun étudiant")
        Else
            If Eleve._Nb_Etu.Count = 0 Then
                MsgBox("Il n'y a pas d'élève sur la liste")
            Else
                Dim rep As MsgBoxResult
                rep = MsgBox("Êtes-vous sûr de vouloir supprimer l'élève?", MsgBoxStyle.YesNo, "Supprimer")
                If rep = MsgBoxResult.Yes Then
                    ListeE.Supprimer(No_E)
                    txtDA.Text = ""
                    txtNom.Text = ""
                    txtPrenom.Text = ""
                    ComboBoxSexe.Text = ""
                    txtVille.Text = ""
                    numNbcoursereussi.Value = 0
                    NumMoyenne.Value = 0
                    ComboBoxStatut.Text = ""
                Else
                    Return
                End If
            End If
        End If
    End Sub

    Private Sub cmdCalculeMoyenne_Click(sender As Object, e As EventArgs) Handles cmdCalculeMoyenne.Click
        Dim moyenne As Single = Eleve.CalculerMoyenne()
        MsgBox("La moyenne des élèves est de: " & moyenne)
    End Sub

    Private Sub cmdListerEleve_Click(sender As Object, e As EventArgs) Handles cmdListerEleve.Click

        ListeE.Remplir_LV()

    End Sub



#End Region



End Class
