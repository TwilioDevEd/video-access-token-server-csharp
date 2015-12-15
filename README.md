# Video Quickstart for C# (ASP.NET MVC)

This application should give you a ready-made starting point for writing your
own video apps with Twilio Video. Before we begin, we need to collect
all the config values we need to run the application:

| Config Value  | Description |
| :-------------  |:------------- |
Configuration Profile SID | Identifier for a set of config properties for your video application - [find yours here](https://www.twilio.com/user/account/video/profiles).
Account SID | Your primary Twilio account identifier - find this [in the console here](https://www.twilio.com/user/account/video).
API Key | Used to authenticate - [generate one here](https://www.twilio.com/user/account/video/dev-tools/api-keys).
API Secret | Used to authenticate - [just like the above, you'll get one here](https://www.twilio.com/user/account/video/dev-tools/api-keys).

## A Note on API Keys

When you generate an API key pair at the URLs above, your API Secret will only
be shown once - make sure to save this in a secure location, 
or possibly your system environment variables.

## Setting Up The Application

After downloading or cloning this application, create a new file in `VideoQuickstart`
(at the same level as `VideoQuickstart\Web.config`) called `LocalConfig`

After downloading the repo, copy the `TwilioIpMessaging/Web.config.example` to
`Web.config` in the same directory. Next, open up `TwilioIpMessaging.sln` in
Visual Studio.  Edit `Web.config` with the four values we obtained above:

```xml
<appSettings>
	<add key="TwilioAccountSid" value="ACxxx" />
	<add key="TwilioApiKey" value="SKxxx" />
	<add key="TwilioApiSecret" value="xxxxxxxx" />
	<add key="TwilioConfigurationSid" value="VSxxxx" />
</appSettings>
```

You should now be ready to rock! Hit `F5` or the Play button, and you should 
land on the home page of our basic chat application. Open it up in a few browser
tabs and start video chatting with yourself! Note that Twilio video requires
WebRTC enabled browsers, so Edge and Internet Explorer will not work for testing.
We'd recommend Google Chrome or Mozilla Firefox instead.

![screenshot of chat app](http://i.imgur.com/nVR70FQ.png)

## License

MIT
