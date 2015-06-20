# DnnC CookieConsent

## What is DnnC CookieConsent
DnnC CookieConsent is a SkinObject and is created using the “Cookie Consent” plugin from silkTide and adapted to a skinObject for Dnn CMS Platform. 

Documentation for the Siktide script can be found here : https://silktide.com/tools/cookie-consent/docs/

Demo of the SkinObject in action:

http://www.cmsxpress.nl

http://www.interschools.nl

## What is the DnnC CookieConsent SkinObject for?

The EU Cookie Law says that websites must get "informed consent" from users before they record any detailed information in the cookies they store on visitor’s computer. On 26th May 2011, new laws came into force that affect most web sites. If cookies are used in a site, the Privacy and Electronic Communications (EC Directive) (Amendment) Regulations 2011 (UK Regulations) provide that certain information must be given to that site's visitors and the user must give his or her consent to the placing of the cookies.

The DnnC CookieConsent SkinObject helps you and your site to comply with this law.

## Compliance

#### This section outlines how you can comply with the EU Cookie Law.

#### What does the law say?
From May 2011 a new privacy law came into effect across the EU. The law requires that websites ask visitors for consent to use most web cookies.

Nearly all websites use cookies, which are an extremely common technology for remembering anything about a visitor between webpages. Cookies are commonly used for login, remembering preferences, tracking visitors and more.

The law provides some exceptions for “strictly necessary” cookies, but there is considerable disagreement over what this means. Cookie Consent is based upon the simplest compliance approach that has become common across the Internet since 2011.

#### Will DnnC CookieConsent make me compliant with the law?
If you install Cookie Consent, you will be informing your users that your website is using cookies. This is the same approach that Google, Twitter and more have taken towards compliance: continue to use cookies, but tell users that they’re being used (often called ‘implied opt in’).

Whilst we can’t guarantee that our plugin will constitute total compliance for everyone in the EU, this approach does appear to have satisfied regulators for the time being. If you’re confused by the law and its vague requirements, you’re in good company.

#### Do I need to do anything else?
Simply telling users that your site uses cookies is the absolute bare minimum. Cookie Consent allows you to link to a cookie or privacy policy, if you have one. To comply with the law, we strongly recommend that you prepare a brief policy and link to it. Here’s [Silktides privacy policy](https://silktide.com/tools/cookie-consent/docs/compliance), as an example.


**Requirements** Dnn 06.02.00 and up

**Installation** The installation of the Skinobject follows the same process as a Dnn Module:
1. BackUp your Dnn install and database.
2. Login as 'Host' of your install.
3. Navigate to : Host > Extensions then clickthe 'Install Extension Wizard' button and follow the instructions.
4. Once the SkinObject has been installed, edit your Skin file(s) to add the SkinObject

## How to use DnnC CookieConsent in your skin
The SkinObject is used in your skin and is used the same way as other SkinObject.

In your skin file(s) add the registration to the top of your skin as below:

```html
<%@ Register TagPrefix="dnn" TagName="COOKIECONSENT" Src="~/DesktopModules/DnnC_CookieConsent/CookieConsent.ascx" %>
```

Next add the following to you skin:

```html
<dnn:CookieConsent runat="server" />
```

To link the CookieConsent bar to your cookie policy page, use the 'CookiePolicyLink' setting:

```html
<dnn:CookieConsent runat="server" CookiePolicyLink="http://www.mysite.com/cookiepolicy.aspx" />
```
(change www.mysite.com and page to corrispond to your website)

To change the look and position of the CookieConsent bar, use the 'CookieTheme' setting:

```html
<dnn:CookieConsent runat="server" CookieTheme="light-bottom" CookiePolicyLink="http://www.mysite.com/cookiepolicy.aspx" />
```

The builtin themes are as follows:
- dark-top (default)
- dark-floating
- dark-bottom
- light-floating
- light-top
- light-bottom

When you choose "light-floating" or "dark-floating" a cookieconsent logo appears, if you want to hide this just add the following piece of css to your style sheet:

```css
a.cc_logo { visibility:hidden; }
```
