Imports System.IO


'Structure Etudiant...
Public Structure Etudiant
    Public DA As String
    Public Nom As String
    Public Prenom As String
    Public Sexe As Char
    Public Ville As String
    Public NbCoursReussi As Integer
    Public Moyenne As Single
    Public Statut As Char

End Structure

Public Class Eleve

    'Liste des Etudiants (tableau dynamique)
    Public Shared _Nb_Etu As ArrayList
    Private Shared _NbConnexion As Integer


    Public Shared ReadOnly Property NbConnexion As Integer
        Get
            Return _NbConnexion
        End Get
    End Property

    Public ReadOnly Property Etudiants(no As Integer) As Etudiant
        Get
            Return _Nb_Etu(no)
        End Get
    End Property

    'Constructeur qui récupérer le contenu du fichier..."
    Public Sub New()
        If _NbConnexion = 0 Then
            _Nb_Etu = New ArrayList
            'Récupérer le contenu du fichier
            Dim Fs As New FileStream("Etudiant.txt", FileMode.OpenOrCreate, FileAccess.Read, FileShare.None)
            Dim SR As New StreamReader(Fs)
            'Lire le contenu du fichier
            Dim ligne As String
            ligne = SR.ReadLine
            Do While ligne <> ""

                'Delimiter les champs 
                Dim champs() As String = ligne.Split(";")
                Dim E As Etudiant
                E.DA = champs(0)
                E.Nom = champs(1)
                E.Prenom = champs(2)
                E.Sexe = champs(3)
                E.Ville = champs(4)
                E.NbCoursReussi = champs(5)
                E.Moyenne = champs(6)
                E.Statut = champs(7)
                _Nb_Etu.Add(E)
                ligne = SR.ReadLine
            Loop
            SR.Close()
            Fs.Close()
        End If
        _NbConnexion += 1

    End Sub


    'Permet de récréer le fichier avec les ajustments...(Ajout, modif, dest)
    Protected Overrides Sub Finalize()
        _NbConnexion -= 1
        If _NbConnexion = 0 Then
            'Récupérer le contenu du fichier
            Dim Fs As New FileStream("Etudiant.txt", FileMode.Create, FileAccess.Write, FileShare.None)
            Dim SW As New StreamWriter(Fs)
            'Lire le contenu de la liste
            Dim E As Etudiant
            Dim i As Integer
            For i = 0 To _Nb_Etu.Count - 1
                E = _Nb_Etu(i)
                SW.WriteLine(E.DA & ";" & E.Nom & ";" & E.Prenom & ";" & E.Sexe & ";" & E.Ville & ";" & E.NbCoursReussi & ";" & E.Moyenne & ";" & E.Statut)
            Next
            SW.Close()
            Fs.Close()
        End If
    End Sub


    Public Sub Ajouter(DA As String, Nom As String, Prenom As String, Sexe As Char, Ville As String, NbCoursReussi As Integer, Moyenne As Single, Statut As Char)
        Dim E As Etudiant
        E.DA = DA
        E.Nom = Nom
        E.Prenom = Prenom
        E.Sexe = Sexe
        E.Ville = Ville
        E.NbCoursReussi = NbCoursReussi
        E.Moyenne = Moyenne
        E.Statut = Statut

        'Ajouter le nouveau Etudiant à la liste
        _Nb_Etu.Add(E)
        MsgBox("Étudiant ajouté à la liste")

        'Événement
        If _Nb_Etu.Count Mod 5 Then
            RaiseEvent BesoinProf()
        End If

        If E.NbCoursReussi >= 20 Then
            RaiseEvent DiplomeObtenu()
        End If

        If E.Statut.ToString.ToUpper = "X" Then
            RaiseEvent EchecEleve()
        End If

        If E.NbCoursReussi < 20 Then
            RaiseEvent EchecEleve()
        End If



    End Sub

    Public Sub Modifier(DA As String, Nom As String, Prenom As String, Sexe As Char, Ville As String, NbCoursReussi As Integer, Moyenne As Single, Statut As Char, No_E As Integer)
        Dim E As Etudiant
        E.DA = DA
        E.Nom = Nom
        E.Prenom = Prenom
        E.Sexe = Sexe
        E.Ville = Ville
        E.NbCoursReussi = NbCoursReussi
        E.Moyenne = Moyenne
        E.Statut = Statut


        'Modifie l'étudiant 
        _Nb_Etu.RemoveAt(No_E)
        _Nb_Etu.Insert(No_E, E)
        MsgBox("Étudiant modifié")


        'Événement
        If _Nb_Etu.Count Mod 5 Then
            RaiseEvent BesoinProf()
        End If

        If E.NbCoursReussi >= 20 Then
            RaiseEvent DiplomeObtenu()
        End If

        If E.Statut.ToString.ToUpper = "X" Then
            RaiseEvent EchecEleve()
        End If

        If E.NbCoursReussi < 20 Then
            RaiseEvent EchecEleve()
        End If

    End Sub

    Public Sub Supprimer(No_E As Integer)
        _Nb_Etu.RemoveAt(No_E)
        MsgBox("Étudiant supprimé")

    End Sub

    Public Shared Function CalculerMoyenne() As Single
        'Récupérer le contenu du fichier
        Dim Fs As New FileStream("Etudiant.txt", FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite)
        Dim SR As New StreamReader(Fs)
        'Lire le contenu du fichier
        Dim ligne As String
        ligne = SR.ReadLine
        Dim moyenne As Single = 0

        Do While ligne <> ""
            'Delimiter les champs 
            Dim champs() As String = ligne.Split(";")
            moyenne += champs(6)
            ligne = SR.ReadLine
        Loop
        Return moyenne / _Nb_Etu.Count + 1

        SR.Close()
        Fs.Close()
    End Function

    Public Sub Remplir_LV()
        Dim Fs As New FileStream("Etudiant.txt", FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite)
        Dim Sr As New StreamReader(Fs)
        'Lire le contenu du fichier
        Dim Ligne As String
        Ligne = Sr.ReadLine
        Dim i As Integer = 0
        Form1.lvEleve.Clear()

        Form1.lvEleve.Columns.Add("DA", 150)
        Form1.lvEleve.Columns.Add("Nom", 150)
        Form1.lvEleve.Columns.Add("Prenom", 150)
        Form1.lvEleve.Columns.Add("Sexe", 150)
        Form1.lvEleve.Columns.Add("Ville", 150)
        Form1.lvEleve.Columns.Add("Nb cours reussi", 150)
        Form1.lvEleve.Columns.Add("Moyenne", 150)
        Form1.lvEleve.Columns.Add("Statut", 150)

        Form1.lvEleve.FullRowSelect = True
        Form1.lvEleve.View = View.Details
        Do While Ligne <> ""
            Dim champs() As String = Ligne.Split(";") 'nous permet de delimiter nos champs par des ;

            Dim arr As String() = New String(7) {}

            Dim itm(i) As ListViewItem

            arr(0) = champs(0)
            arr(1) = champs(1)
            arr(2) = champs(2)
            arr(3) = champs(3)
            arr(4) = champs(4)
            arr(5) = champs(5)
            arr(6) = champs(6)
            arr(7) = champs(7)

            itm(i) = New ListViewItem(arr)
            Form1.lvEleve.Items.Add(itm(i))
            i += 1

            Ligne = Sr.ReadLine
        Loop

    End Sub

    Public Event BesoinProf()
    Public Event DiplomeObtenu()
    Public Event EchecEleve()


End Class
