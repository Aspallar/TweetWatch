# TweetWatch

A simple desktop application to monitor a twitter account for new tweets and alert the user when a new tweet is posted.

Does not use the twitter streaming API, instead the accounts main twitter web page is polled periodically to discover new tweets.

Written because I play video games, and these days the first place a company announces that their servers are back up after maintenance is on twitter. Why should I have to keep checking twitter when waiting impatiently for the servers to come back up when a computer can do it for me.

## Configuration

Place a text file called _tweetsites.txt_ in the application folder that contains a list of the twitter accounts that you wish to be able to monitor, one per line.

Place a wav file called _twitalert.wav_ in the application folder. This is the alert sound that will be played when a new tweet is made.

You can change the names of these files by editing the config file. See next section.

## Config file settings

You can change some aspects of the TweetWatch by editing the TweetWatch.exe.config file in the application folder. The values shown below are the defaults.

```xml
<applicationSettings>
    <TweetWatch.Properties.Settings>
        <setting name="ColorString" serializeAs="String">
            <value>DodgerBlue</value>
        </setting>
        <setting name="Sound" serializeAs="String">
            <value>Twitalert.wav</value>
        </setting>
        <setting name="Period" serializeAs="String">
            <value>10000</value>
        </setting>
        <setting name="MinimizeToSystemTray" serializeAs="String">
            <value>True</value>
        </setting>
        <setting name="TwitListFile" serializeAs="String">
            <value>tweetsites.txt</value>
        </setting>
    </TweetWatch.Properties.Settings>
</applicationSettings>
```

| Item   | Description |
|--------|-------------|
| ColorString | The color to use for the title bar. It can be a named color (e.g DarkBlue), or a html color (e.g #F0F0F0), or a comma separated RGB color (e.g 20,138,99) or a comma separated ARGB color (e.g 100,128,64,128). For a list of named colors see [Named Colors](https://docs.microsoft.com/en-us/dotnet/api/system.drawing.knowncolor?view=netframework-4.6.1). |
| Period | Period in milliseconds to poll twitter for new tweets. |
| MinimizeToSystemTray | True = TweetWatch is minimized to the system tray. New tweets will be shown in a tooltip balloon when the application is minimized. False = TweetWatch is minimized normally. |
| Sound<sup>*</sup> | The name of the wav file to use as the alert sound. |
| TwitListFile<sup>*</sup> | The name of the file containing the list of twitter accounts. |

<sup>*</sup> You can specify either a relative file path or an absolute path to the file. If a relative path is specified it will be relative to the application folder.
