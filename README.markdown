DeployBean
====================

Beanstalk Deployments from your windows system tray.
---------------------

### Quick Install - Precompiled Binaries 

- Download the [binaries](https://github.com/downloads/digistump/DeployBean/DeployBean.zip) or [installer](https://github.com/downloads/digistump/DeployBean/DeployBeanInstall.zip) from the Downloads page
- Install / Unzip where you want it
- Start from your Start Menu or DeployBean.exe
- Right-click on the tray icon and go to settings
- You're good to go!

*.NET Framework 4 is required - the install will download it if you don't have it*


Features
----------------------

- Click the Tray icon to bring up the deployment menu.
- Navigate the menu with arrow keys + enter or the mouse.
- Set a hotkey form the settings menu to launch the deploy menu.
- It will remember the last repository you selected, and the last enviroment for each repository.
- The latest commit will always be selected.
- Only non-current enviroments show (if you select a past commit it will show current ones for roll-back).
- Tray notification on deployment scucess or failure.
- Add a second account to access two accounts from the same menu.

Hacking on DeployBean
----------------------

- Grab the VB.NET project by grabbings this repo and edit with Visual Studio or Visual Basic Express 2010
- Open DeployBean.vbproj and hack away

### If you make any improvements please send a pull request!


Troubleshooting
----------------------

If the program crashes it's likely due to no internet connection, being behind a proxy (no proxy support yet), or bad login information.

Make sure you have the API enabled in you Beanstalk account - this could also cause it to crash.

This is by no means a polished program - very little error control is present - but given the nature of the Beanstalk API this means crashes are possible, not mistaken deployments.


License
----------------------

DeployBean is released under the GNU General Public License - [http://www.gnu.org/licenses/gpl.html](http://www.gnu.org/licenses/gpl.html)


Donations
----------------------

*Want to support my development of this app and other open source software?*

Then send your pull requests

Or donate - [PayPal Donate](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=JUV2MXNUUKN2S)

*Want a specific feature added?*

Download the repo and add - don't forget that pull request

Or donate and let me know what you'd like to see

If you are a part of one of those companies that use Beanstalk and find this useful and you want to throw me a free account so I can make more cool stuff like this, that'd be awesome. 
digistump (a_t) gmail (d_o_t) com

###Special thanks to Beanstalk for providing a test account for development of this app