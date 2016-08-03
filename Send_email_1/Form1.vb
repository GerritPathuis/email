Imports System
Imports System.Net
Imports System.Net.Mail

Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        send_mail()
    End Sub

    Private Sub send_mail()
        Dim Smtp_Server As New SmtpClient
        Dim e_mail As New MailMessage()

        Smtp_Server.UseDefaultCredentials = False
        Smtp_Server.Credentials = New Net.NetworkCredential("g.pathuis@zoho.com", "BMWRS1200")
        Smtp_Server.Port = 587
        Smtp_Server.EnableSsl = True
        Smtp_Server.Host = "smtp.zoho.com"
        e_mail = New MailMessage()
        e_mail.From = New MailAddress("g.pathuis@zoho.com")
        e_mail.To.Add("g.pathuis@quicknet.nl")
        e_mail.Subject = "Testing"
        e_mail.IsBodyHtml = False
        e_mail.Body = "This is the body content send in VB.net test4"

        Smtp_Server.Send(e_mail)
    End Sub
End Class




