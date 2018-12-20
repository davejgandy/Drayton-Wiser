# Wiser
Control interface for Drayton Wiser (.net v4.0)

Designed to create a standalone control interface for Drayton Wiser Heating control, running on a windows tablet, but obviously will run on a PC as well.
(Written in c#, targeting .Net v4.0)

Not intended to replace the official app, and as such doesn't currently provide all the functionality (e.g. scheduling).

Does including a monitoring component and tracks temperature and battery data to a LiteDB database.  Also added a system tray app for quick access to room temps and boost.

(The code structure needs tidying up - there's some old/test code in there - will try to get it cleaned up and tidy)

There are several components:

Wiser - this is the main component and connects to the hub

WiserControl - Windows application designed for tablet (to mimic the EvoHome Controller)

WiserMonitor - Provides interfaces to log to a LiteDB database & export CSV data

SystemTrayApp - Windows app which appears as a system tray icon only - right click to see room temps and apply boosts
