# Video Access Token Server for C# (ASP.NET MVC)

#### Looking for the JavaScript Video Quickstart? It has been moved [here](https://github.com/twilio/video-quickstart-js).

This server-side application demonstrates generating Access Token for Twilio Video.
Before we begin, we need to collect all the config values we need to run the application:

| Config Value  | Description |
| :-------------  |:------------- |
Account SID | Your primary Twilio account identifier - find this [in the console here](https://www.twilio.com/console).
API Key | Used to authenticate - [generate one here](https://www.twilio.com/console/video/runtime/api-keys).
API Secret | Used to authenticate - [just like the above, you'll get one here](https://www.twilio.com/console/video/runtime/api-keys).

## A Note on API Keys

When you generate an API key pair at the URLs above, your API Secret will only
be shown once - make sure to save this in a secure location, 
or possibly your system environment variables.

## Setting up the Application

After downloading the repo, copy the `VideoAccessTokenServer/Local.config.example` to `Local.config` in the same directory.
Next, open up `VideoAccessTokenServer.sln` in Visual Studio. Edit `Local.config` with the three values we obtained above:

```xml
<appSettings>
    <add key="TwilioAccountSid" value="your_account_sid"/>
    <add key="TwilioApiKey" value="your_api_key"/>
    <add key="TwilioApiSecret" value="your_api_secret"/>
</appSettings>

```

To generate Access Token, hit `F5` or the Play button, and you should see the Access Token in your browser window.

## License

MIT
