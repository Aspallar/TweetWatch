# TweetWatch

A simple desktop application to monitor a twitter account for new tweets and alert the user when a new tweet is posted.

Does not use the twitter streaming API, instead the accounts main twitter web page is polled periodically to discover new tweets.

Written because I play video games, and these days the first place a company announces that their servers are back up after maintenance is on twitter. Why should I have to keep checking twitter when waiting impatiently for the servers to come back up when a computer can do it for me.

## Configuration

Place a text file called _tweetsites.txt_ in the application folder that contains a list of the twitter accounts that you wish to be able to monitor, one per line.

Place a wav file called _twitalert.wav_ in the application folder. This is the alert sound that will be played when a new tweet is made.
