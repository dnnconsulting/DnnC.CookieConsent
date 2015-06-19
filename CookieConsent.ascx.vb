' ------------------ Copyright (c) notice DnnConsulting ------------------
'  Copyright (c) 2015 DnnConsulting.  www.DnnConsulting.nl. BSD License.
'  Author: G. M. Barlow
' ------------------------------------------------------------------------
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS 
' OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
' FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
' AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER 
' LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
' OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN 
' THE SOFTWARE.
' ------------------------------------------------------------------------
' This copyright notice may NOT be removed, obscured or modified without written
' consent from the author.
' ------------------------- End copyright notice ------------------------- 

Imports DotNetNuke
Imports DotNetNuke.Entities.Modules.Actions
Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.Services.Exceptions
Imports DotNetNuke.Services.Localization
Imports DotNetNuke.Web.Client.ClientResourceManagement

Public Class CookieConsent
    Inherits DotNetNuke.UI.Skins.SkinObjectBase

#Region " Public Members"
    Const MyFileName As String = "CookieConsent.ascx"
    Private _cookiePolicyLink As String = "null"
    Private _cookieTheme As String = "dark-top"      ' dark-top, dark-floating, dark-bottom, light-floating, light-top, light-bottom


#End Region

#Region " Private Members"

    Public Property CookiePolicyLink() As String
        Get
            Return LCase(_cookiePolicyLink)
        End Get
        Set(ByVal Value As String)
            _cookiePolicyLink = LCase(Value)
        End Set
    End Property

    Public Property CookieTheme() As String
        Get
            Return LCase(_cookieTheme)
        End Get
        Set(ByVal Value As String)
            _cookieTheme = LCase(Value)
        End Set
    End Property

#End Region

#Region " Event Methods"

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Try
            If Not Page.ClientScript.IsClientScriptBlockRegistered("CookieConsent") Then
                Dim strCookieScript As String = BuildCookieConsentScript()
                ltlScript.Text = strCookieScript
                ClientResourceManager.RegisterScript(Parent.Page, "//s3.amazonaws.com/cc.silktide.com/cookieconsent.1.0.2.min.js")

            End If
        Catch exc As Exception
            Exceptions.ProcessModuleLoadException(Me, exc)
        End Try

    End Sub

#End Region

#Region " Private Methods"

    Private Function BuildCookieConsentScript() As String
        Dim jQueryStr As StringBuilder = New StringBuilder
        jQueryStr.AppendLine("<script type=""text/javascript"">")
        jQueryStr.AppendLine("    window.cookieconsent_options = {")
        jQueryStr.AppendLine("        message: """ & Localization.GetString("lblMessage", Localization.GetResourceFile(Me, MyFileName)) & """,")
        jQueryStr.AppendLine("        dismiss: """ & Localization.GetString("lblDismiss", Localization.GetResourceFile(Me, MyFileName)) & """,")
        jQueryStr.AppendLine("        learnMore: """ & Localization.GetString("lblLearnMore", Localization.GetResourceFile(Me, MyFileName)) & """,")
        If _cookiePolicyLink = "null" Then
            jQueryStr.AppendLine("        link: null,")
        Else : jQueryStr.AppendLine("        link: """ & _cookiePolicyLink & """,")
        End If
        jQueryStr.AppendLine("        theme: """ & _cookieTheme & """")
        jQueryStr.AppendLine("    };")
        jQueryStr.AppendLine("</script>")

        Return jQueryStr.ToString
    End Function

#End Region





End Class