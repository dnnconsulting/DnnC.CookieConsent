' Copyright (c) DnnConsulting.nl
' Copyright (c) 2014 DnnConsulting.  www.DnnConsulting.nl. BSD License.
' Author: G. Barlow
' ------------------------------------------------------------------------
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
' DEALINGS IN THE SOFTWARE.
' ------------------------------------------------------------------------
' This copyright notice may NOT be removed, obscured or modified without written consent from the author.
' --- End copyright notice --- 

Imports DotNetNuke
Imports DotNetNuke.Entities.Modules.Actions
Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.Services.Exceptions
Imports DotNetNuke.Services.Localization
Imports DotNetNuke.UI.Skins

Public Class View
    Inherits DotNetNuke.UI.Skins.SkinObjectBase

#Region " Public Members"

    Const MyFileName As String = "View.ascx"

    ' ***** Cooke Types
    Private _analyticsCookie As String = "false"
    Private _socialCookie As String = "false"
    Private _advertisingCookie As String = "false"
    Private _necessaryCookie As String = "false"

    ' ***** SETTINGS
    Private _refreshOnConsent As String = "false"       ' true | false
    Private _style As String = "dark"                   ' dark | light | monochrome
    Private _bannerPosition As String = "top"           ' top | bottom | push
    Private _clickAnyLinkToConsent As String = "false"  ' true | false
    Private _privacyPolicy As String = "false"          ' true | false
    Private _collectStatistics As String = "false"      ' true | false
    Private _tagPosition As String = "bottom-right"     ' bottom-right | bottom-left | left-side | right-side
    Private _useSSL As String = "false"                 ' true | false
    Private _serveraddr As String = "http://cookieconsent.silktide.com/"
    Private _clearprefs As String = "false"             ' true | false
    Private _consenttype As String = "explicit"         ' explicit | implicit
    Private _onlyshowbanneronce As String = "false"     ' true | false
    Private _hideallsitesbutton As String = "true"      ' true | false
    Private _disableallsites As String = "false"        ' true | false
    Private _hideprivacysettingstab As String = "false" ' true | false
    Private _scriptdelay As String = "800"
    Private _testmode As String = "false"               ' true | false
    Private _overridewarnings As String = "false"       ' true | false
    Private _onlyshowwithineu As String = "false"       ' true | false
    Private _ipinfodbkey As String = "false"            ' true | false

#End Region

#Region " Private Members"

    Public Property AnalyticsCookie() As String
        Get
            Return LCase(_analyticsCookie)
        End Get
        Set(ByVal Value As String)
            _analyticsCookie = LCase(Value)
        End Set
    End Property
    Public Property SocialCookie() As String
        Get
            Return LCase(_socialCookie)
        End Get
        Set(ByVal Value As String)
            _socialCookie = LCase(Value)
        End Set
    End Property
    Public Property AdvertisingCookie() As String
        Get
            Return LCase(_advertisingCookie)
        End Get
        Set(ByVal Value As String)
            _advertisingCookie = LCase(Value)
        End Set
    End Property
    Public Property NecessaryCookie() As String
        Get
            Return LCase(_necessaryCookie)
        End Get
        Set(ByVal Value As String)
            _necessaryCookie = LCase(Value)
        End Set
    End Property


    Public Property RefreshOnConsent() As String
        Get
            Return LCase(_refreshOnConsent)
        End Get
        Set(ByVal Value As String)
            _refreshOnConsent = LCase(Value)
        End Set
    End Property
    Public Property ObjectStyle() As String
        Get
            Return LCase(_style)
        End Get
        Set(ByVal Value As String)
            _style = LCase(Value)
        End Set
    End Property
    Public Property BannerPosition() As String
        Get
            Return LCase(_bannerPosition)
        End Get
        Set(ByVal Value As String)
            _bannerPosition = LCase(Value)
        End Set
    End Property
    Public Property ClickAnyLinkToConsent() As String
        Get
            Return LCase(_clickAnyLinkToConsent)
        End Get
        Set(ByVal Value As String)
            _clickAnyLinkToConsent = LCase(Value)
        End Set
    End Property
    Public Property PrivacyPolicy() As String
        Get
            Return LCase(_privacyPolicy)
        End Get
        Set(ByVal Value As String)
            _privacyPolicy = LCase(Value)
        End Set
    End Property
    Public Property CollectStatistics() As String
        Get
            Return LCase(_collectStatistics)
        End Get
        Set(ByVal Value As String)
            _collectStatistics = LCase(Value)
        End Set
    End Property
    Public Property TagPosition() As String
        Get
            Return LCase(_tagPosition)
        End Get
        Set(ByVal Value As String)
            _tagPosition = LCase(Value)
        End Set
    End Property
    Public Property UseSSL() As String
        Get
            Return LCase(_useSSL)
        End Get
        Set(ByVal Value As String)
            _useSSL = LCase(Value)
        End Set
    End Property
    Public Property ServerAddress() As String
        Get
            Return LCase(_serveraddr)
        End Get
        Set(ByVal Value As String)
            _serveraddr = LCase(Value)
        End Set
    End Property
    Public Property ClearPreferences() As String
        Get
            Return LCase(_clearprefs)
        End Get
        Set(ByVal Value As String)
            _clearprefs = LCase(Value)
        End Set
    End Property
    Public Property ConsentType() As String
        Get
            Return LCase(_consenttype)
        End Get
        Set(ByVal Value As String)
            _consenttype = LCase(Value)
        End Set
    End Property
    Public Property OnlyShowBannerOnce() As String
        Get
            Return LCase(_onlyshowbanneronce)
        End Get
        Set(ByVal Value As String)
            _onlyshowbanneronce = LCase(Value)
        End Set
    End Property
    Public Property HideAllSitesButton() As String
        Get
            Return LCase(_hideallsitesbutton)
        End Get
        Set(ByVal Value As String)
            _hideallsitesbutton = LCase(Value)
        End Set
    End Property
    Public Property DisableAllSites() As String
        Get
            Return LCase(_disableallsites)
        End Get
        Set(ByVal Value As String)
            _disableallsites = LCase(Value)
        End Set
    End Property
    Public Property HidePrivacySettingsTab() As String
        Get
            Return LCase(_hideprivacysettingstab)
        End Get
        Set(ByVal Value As String)
            _hideprivacysettingstab = LCase(Value)
        End Set
    End Property
    Public Property ScriptDelay() As String
        Get
            Return LCase(_scriptdelay)
        End Get
        Set(ByVal Value As String)
            _scriptdelay = LCase(Value)
        End Set
    End Property
    Public Property TestMode() As String
        Get
            Return LCase(_testmode)
        End Get
        Set(ByVal Value As String)
            _testmode = LCase(Value)
        End Set
    End Property
    Public Property OverrideWarnings() As String
        Get
            Return LCase(_overridewarnings)
        End Get
        Set(ByVal Value As String)
            _overridewarnings = LCase(Value)
        End Set
    End Property
    Public Property OnlyShowWithinEU() As String
        Get
            Return LCase(_onlyshowwithineu)
        End Get
        Set(ByVal Value As String)
            _onlyshowwithineu = LCase(Value)
        End Set
    End Property
    Public Property IPInfodbKey() As String
        Get
            Return LCase(_ipinfodbkey)
        End Get
        Set(ByVal Value As String)
            _ipinfodbkey = LCase(Value)
        End Set
    End Property

#End Region

#Region "Event Methods"

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Try

            If Not Page.ClientScript.IsClientScriptBlockRegistered("CookieConsent2") Then
                SetUpStyles()
                SetUpScript()
            End If

        Catch exc As Exception
            Exceptions.ProcessModuleLoadException(Me, exc)
        End Try
    End Sub

    Private Sub SetUpStyles()

    End Sub

    Private Sub SetUpScript()
        Dim jQueryStr As StringBuilder = New StringBuilder

        jQueryStr.AppendLine("<script type=""text/javascript"">")
        jQueryStr.AppendLine("// <![CDATA[")
        jQueryStr.AppendLine("    cc.initialise({")
        jQueryStr.AppendLine("        cookies: {")

        If CBool(_analyticsCookie) Then jQueryStr.Append("            analytics: {}")

        If CBool(_socialCookie) Then
            If CBool(_analyticsCookie) Then
                jQueryStr.AppendLine(", ")
                jQueryStr.Append("            social: {}")
            Else
                jQueryStr.Append("            social: {}")
            End If
        End If

        If CBool(_advertisingCookie) Then
            If CBool(_analyticsCookie) Or CBool(_socialCookie) Then
                jQueryStr.AppendLine(", ")
                jQueryStr.Append("            advertising: {}")
            Else
                jQueryStr.Append("            advertising: {}")
            End If
        End If

        If CBool(_necessaryCookie) Then
            If CBool(_analyticsCookie) Or CBool(_socialCookie) Or CBool(_advertisingCookie) Then
                jQueryStr.AppendLine(", ")
                jQueryStr.Append("            necessary: {}")
            Else
                jQueryStr.Append("            necessary: {}")
            End If
        End If

        jQueryStr.AppendLine("},")
        jQueryStr.AppendLine("        settings: {")
        jQueryStr.AppendLine("            refreshOnConsent: " & _refreshOnConsent & ",")
        jQueryStr.AppendLine("            style: """ & _style & """,")
        jQueryStr.AppendLine("            bannerPosition: """ & _bannerPosition & """,")
        jQueryStr.AppendLine("            clickAnyLinkToConsent: " & _clickAnyLinkToConsent & ",")
        jQueryStr.AppendLine("            privacyPolicy: " & _privacyPolicy & ",")
        jQueryStr.AppendLine("            collectStatistics: " & _collectStatistics & ",")
        jQueryStr.AppendLine("            tagPosition: """ & TagPosition & """,")
        jQueryStr.AppendLine("            useSSL: " & _useSSL & ",")
        jQueryStr.AppendLine("            serveraddr: """ & _serveraddr & """,")
        jQueryStr.AppendLine("            clearprefs: """ & _clearprefs & """,")
        jQueryStr.AppendLine("            consenttype: """ & _consenttype & """,")
        jQueryStr.AppendLine("            onlyshowbanneronce: " & _onlyshowbanneronce & ",")
        jQueryStr.AppendLine("            hideallsitesbutton: " & _hideallsitesbutton & ",")
        jQueryStr.AppendLine("            disableallsites: " & _disableallsites & ",")
        jQueryStr.AppendLine("            hideprivacysettingstab: " & _hideprivacysettingstab & ",")
        jQueryStr.AppendLine("            scriptdelay: " & _scriptdelay & ",")
        jQueryStr.AppendLine("            testmode: " & _testmode & ",")
        jQueryStr.AppendLine("            overridewarnings: " & _overridewarnings & ",")
        jQueryStr.AppendLine("            onlyshowwithineu: " & _onlyshowwithineu & ",")
        jQueryStr.AppendLine("            ipinfodbkey: " & _ipinfodbkey & ",")
        jQueryStr.AppendLine("        },")
        jQueryStr.AppendLine("        strings: {")
        jQueryStr.AppendLine("            necessaryDefaultTitle: """ & Services.Localization.Localization.GetString("necessaryDefaultTitle", Services.Localization.Localization.GetResourceFile(Me, MyFileName)) & """,")
        jQueryStr.AppendLine("            socialDefaultTitle: """ & Services.Localization.Localization.GetString("socialDefaultTitle", Services.Localization.Localization.GetResourceFile(Me, MyFileName)) & """,")
        jQueryStr.AppendLine("            analyticsDefaultTitle: """ & Services.Localization.Localization.GetString("analyticsDefaultTitle", Services.Localization.Localization.GetResourceFile(Me, MyFileName)) & """,")
        jQueryStr.AppendLine("            advertisingDefaultTitle: """ & Services.Localization.Localization.GetString("advertisingDefaultTitle", Services.Localization.Localization.GetResourceFile(Me, MyFileName)) & """,")
        jQueryStr.AppendLine("            defaultTitle: """ & Services.Localization.Localization.GetString("defaultTitle", Services.Localization.Localization.GetResourceFile(Me, MyFileName)) & """,")
        jQueryStr.AppendLine("            necessaryDefaultDescription: """ & Services.Localization.Localization.GetString("necessaryDefaultDescription", Services.Localization.Localization.GetResourceFile(Me, MyFileName)) & """,")
        jQueryStr.AppendLine("            socialDefaultDescription: """ & Services.Localization.Localization.GetString("socialDefaultDescription", Services.Localization.Localization.GetResourceFile(Me, MyFileName)) & """,")
        jQueryStr.AppendLine("            analyticsDefaultDescription: """ & Services.Localization.Localization.GetString("analyticsDefaultDescription", Services.Localization.Localization.GetResourceFile(Me, MyFileName)) & """,")
        jQueryStr.AppendLine("            advertisingDefaultDescription: """ & Services.Localization.Localization.GetString("advertisingDefaultDescription", Services.Localization.Localization.GetResourceFile(Me, MyFileName)) & """,")
        jQueryStr.AppendLine("            defaultDescription: """ & Services.Localization.Localization.GetString("defaultDescription", Services.Localization.Localization.GetResourceFile(Me, MyFileName)) & """,")
        jQueryStr.AppendLine("            notificationTitle: """ & Services.Localization.Localization.GetString("notificationTitle", Services.Localization.Localization.GetResourceFile(Me, MyFileName)) & """,")
        jQueryStr.AppendLine("            notificationTitleImplicit: """ & Services.Localization.Localization.GetString("notificationTitleImplicit", Services.Localization.Localization.GetResourceFile(Me, MyFileName)) & """,")
        jQueryStr.AppendLine("            poweredBy: """ & Services.Localization.Localization.GetString("poweredBy", Services.Localization.Localization.GetResourceFile(Me, MyFileName)) & """,")
        jQueryStr.AppendLine("            privacyPolicy: """ & Services.Localization.Localization.GetString("privacyPolicy", Services.Localization.Localization.GetResourceFile(Me, MyFileName)) & """,")
        jQueryStr.AppendLine("            learnMore: """ & Services.Localization.Localization.GetString("learnMore", Services.Localization.Localization.GetResourceFile(Me, MyFileName)) & """,")
        jQueryStr.AppendLine("            seeDetails: """ & Services.Localization.Localization.GetString("seeDetails", Services.Localization.Localization.GetResourceFile(Me, MyFileName)) & """,")
        jQueryStr.AppendLine("            seeDetailsImplicit: """ & Services.Localization.Localization.GetString("seeDetailsImplicit", Services.Localization.Localization.GetResourceFile(Me, MyFileName)) & """,")
        jQueryStr.AppendLine("            hideDetails: """ & Services.Localization.Localization.GetString("hideDetails", Services.Localization.Localization.GetResourceFile(Me, MyFileName)) & """,")
        jQueryStr.AppendLine("            savePreference: """ & Services.Localization.Localization.GetString("savePreference", Services.Localization.Localization.GetResourceFile(Me, MyFileName)) & """,")
        jQueryStr.AppendLine("            saveForAllSites: """ & Services.Localization.Localization.GetString("saveForAllSites", Services.Localization.Localization.GetResourceFile(Me, MyFileName)) & """,")
        jQueryStr.AppendLine("            allowCookies: """ & Services.Localization.Localization.GetString("allowCookies", Services.Localization.Localization.GetResourceFile(Me, MyFileName)) & """,")
        jQueryStr.AppendLine("            allowCookiesImplicit: """ & Services.Localization.Localization.GetString("allowCookiesImplicit", Services.Localization.Localization.GetResourceFile(Me, MyFileName)) & """,")
        jQueryStr.AppendLine("            allowForAllSites: """ & Services.Localization.Localization.GetString("allowForAllSites", Services.Localization.Localization.GetResourceFile(Me, MyFileName)) & """,")
        jQueryStr.AppendLine("            customCookie: """ & Services.Localization.Localization.GetString("customCookie", Services.Localization.Localization.GetResourceFile(Me, MyFileName)) & """,")
        jQueryStr.AppendLine("            privacySettings: """ & Services.Localization.Localization.GetString("privacySettings", Services.Localization.Localization.GetResourceFile(Me, MyFileName)) & """,")
        jQueryStr.AppendLine("            privacySettingsDialogTitleA: """ & Services.Localization.Localization.GetString("privacySettingsDialogTitleA", Services.Localization.Localization.GetResourceFile(Me, MyFileName)) & """,")
        jQueryStr.AppendLine("            privacySettingsDialogTitleB: """ & Services.Localization.Localization.GetString("privacySettingsDialogTitleB", Services.Localization.Localization.GetResourceFile(Me, MyFileName)) & """,")
        jQueryStr.AppendLine("            privacySettingsDialogSubtitle: """ & Services.Localization.Localization.GetString("privacySettingsDialogSubtitle", Services.Localization.Localization.GetResourceFile(Me, MyFileName)) & """,")
        jQueryStr.AppendLine("            closeWindow: """ & Services.Localization.Localization.GetString("closeWindow", Services.Localization.Localization.GetResourceFile(Me, MyFileName)) & """,")
        jQueryStr.AppendLine("            changeForAllSitesLink: """ & Services.Localization.Localization.GetString("changeForAllSitesLink", Services.Localization.Localization.GetResourceFile(Me, MyFileName)) & """,")
        jQueryStr.AppendLine("            preferenceUseGlobal: """ & Services.Localization.Localization.GetString("preferenceUseGlobal", Services.Localization.Localization.GetResourceFile(Me, MyFileName)) & """,")
        jQueryStr.AppendLine("            preferenceConsent: """ & Services.Localization.Localization.GetString("preferenceConsent", Services.Localization.Localization.GetResourceFile(Me, MyFileName)) & """,")
        jQueryStr.AppendLine("            preferenceDecline: """ & Services.Localization.Localization.GetString("preferenceDecline", Services.Localization.Localization.GetResourceFile(Me, MyFileName)) & """,")
        jQueryStr.AppendLine("            preferenceAsk: """ & Services.Localization.Localization.GetString("preferenceAsk", Services.Localization.Localization.GetResourceFile(Me, MyFileName)) & """,")
        jQueryStr.AppendLine("            preferenceAlways: """ & Services.Localization.Localization.GetString("preferenceAlways", Services.Localization.Localization.GetResourceFile(Me, MyFileName)) & """,")
        jQueryStr.AppendLine("            preferenceNever: """ & Services.Localization.Localization.GetString("preferenceNever", Services.Localization.Localization.GetResourceFile(Me, MyFileName)) & """,")
        jQueryStr.AppendLine("            notUsingCookies: """ & Services.Localization.Localization.GetString("notUsingCookies", Services.Localization.Localization.GetResourceFile(Me, MyFileName)) & """,")
        jQueryStr.AppendLine("            clearedCookies: """ & Services.Localization.Localization.GetString("clearedCookies", Services.Localization.Localization.GetResourceFile(Me, MyFileName)) & """,")
        jQueryStr.AppendLine("            allSitesSettingsDialogTitleA: """ & Services.Localization.Localization.GetString("allSitesSettingsDialogTitleA", Services.Localization.Localization.GetResourceFile(Me, MyFileName)) & """,")
        jQueryStr.AppendLine("            allSitesSettingsDialogTitleB: """ & Services.Localization.Localization.GetString("allSitesSettingsDialogTitleB", Services.Localization.Localization.GetResourceFile(Me, MyFileName)) & """,")
        jQueryStr.AppendLine("            allSitesSettingsDialogSubtitle: """ & Services.Localization.Localization.GetString("allSitesSettingsDialogSubtitle", Services.Localization.Localization.GetResourceFile(Me, MyFileName)) & """,")
        jQueryStr.AppendLine("            backToSiteSettings: """ & Services.Localization.Localization.GetString("backToSiteSettings", Services.Localization.Localization.GetResourceFile(Me, MyFileName)) & """,")
        jQueryStr.AppendLine("        }")
        jQueryStr.AppendLine("    });")
        jQueryStr.AppendLine("// ]]>")
        jQueryStr.AppendLine("</script>")

        Page.ClientScript.RegisterClientScriptBlock(Me.GetType, "CookieConsent2", jQueryStr.ToString)
    End Sub

#End Region



End Class