# Wiser
## Control interface for Drayton Wiser 

Designed to create a standalone control interface for Drayton Wiser Heating control, running on a windows tablet, but obviously will run on a PC as well.
(Written in c#, targeting .Net v4.0)

Not intended to replace the official app, and as such doesn't currently provide all the functionality (e.g. scheduling).

Does including a monitoring component and tracks temperature and battery data to a LiteDB database.  Also added a system tray app for quick access to room temps and boost.

There are several components:

- Wiser - this is the main component and connects to the hub
- WiserControl - Windows application designed for tablet (to mimic the EvoHome Controller)
- WiserMonitor - Provides interfaces to log to a LiteDB database & export CSV data
- SystemTrayApp - Windows app which appears as a system tray icon only - right click to see room temps and apply boosts

Based on a lot of work done by Chris Evans and Rob Pope  
https://github.com/chrisduffer/drayton-wiser  
https://github.com/RobPope/DraytonWiser  

## Configuration
Wiser.dll.config needs to be configured with the Heat Hub's "secret" key and IP address 

### Find your secret

Connection to the Drayton hub is done through a local LAN connection rather than via the cloud. This requires an app "secret" that the hub provides. To access this secret you need to jump through a couple of hoops:

1. Log out of the app. Make sure you’re at the login screen
1. Tap Setup / Create Account (even though your system has already been set up).
1. Select the HubR type you have
1. Press the Setup button on the hub
1. This will start the WiserHeatXXX access point.
1. Connect to WiserHeatXXX with you device or a real computer. You should get an IP in the 192.168.8.0/24 range from the hub's DHCP server.
1. Go to http://192.168.8.1/secret/ in a web browser. You'll set a long string of seemingly random numbers. This is your secret!
1. Now finish the setup…
1. Follow the on-screen instructions to connect your smartphone to WiserHeatXXX
1. Tap Skip when prompted to set up your heating system.
1. Follow the on-screen instructions to connect your Heat HubR to the Internet by selecting your new Wi-Fi network.
1. Tap Skip when prompted to register an account.
1. You have now changed to a new Wi-Fi network. You will see the home screen and can proceed to control your heating as normal.

### Find your Wiser hub IP Address

1. Use an app like Fing (https://www.fing.io/) to scan your network for your hub.
1. It will be called something like WiserHeat012A34.
1. Remember the IP address
