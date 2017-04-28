# Video Access Token Server for C# (ASP.NET MVC)

#### Looking for the JavaScript Video Quickstart? It has been moved [here](https://github.com/twilio/video-quickstart-js).

This server-side application demonstrates generating Access Token for Twilio Video.
Before we begin, we need to collect
all the config values we need to run the application:

| Config Value  | Description |
| :-------------  |:------------- |
Account SID | Your primary Twilio account identifier - find this [in the console here](https://www.twilio.com/console).
API Key | Used to authenticate - [generate one here](https://www.twilio.com/console/video/dev-tools/api-keys).
API Secret | Used to authenticate - [just like the above, you'll get one here](https://www.twilio.com/console/video/dev-tools/api-keys).

## A Note on API Keys

When you generate an API key pair at the URLs above, your API Secret will only
be shown once - make sure to save this in a secure location, 
or possibly your system environment variables.

## Setting up the Application

After downloading the repo, copy the `VideoAccessTokenServer/Web.config.example` to `Web.config` in the same directory. Next, open up `VideoAccessTokenServer.sln` in Visual Studio. Edit `Web.config` with the three values we obtained above:

```xml
<appSettings>
  <add key="TwilioAccountSid" value="ACxxx" />
  <add key="TwilioApiKey" value="SKxxx" />
  <add key="TwilioApiSecret" value="xxxxxxxx" />
</appSettings>
```

To generate Access Token, hit `F5` or the Play button, and you should see the Access Token in your browser window.

## License

MIT
