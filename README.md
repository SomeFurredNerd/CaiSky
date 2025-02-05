
# CaiSky

A personal project I made to get accustomed to Visual Studio 2022 to get ready for the course I'm taking this year.

This is a C# WinForms project that uses the Python Bluesky API to login and post. Originally it wasn't really meant to be a public project, but it kind of morphed into some version of a bluesky alternative to the delegate system on Twitter, but due to my inexperience I can't reaallyy make it as secure as I would like, which leads me to the disclaimer.

# Disclaimer for usage on Linux/Non-windows platforms

Currently on non-windows systems, CaiSky stores the username and password in PLAIN TEXT. This is obviously not optimal, and I'm going to try and resolve this. This initially applied to Windows as well, but I've been able to since find a better way to store it on Windows. Unfortunately, I don't think that method works out of the box on Linux, and I don't have a way to test on Linux as of me writing this. I'm planning to set up a VM, just haven't gotten around to it yet.

# Installation

At the moment, this project requires Python added to PATH and the ```atproto``` package manually downloaded using the ```pip``` command in a command prompt. (Hopefully I'll be able to change that in a later release)

First, install the latest version of [Python](https://www.python.org/downloads/). If this is your first time installing Python, make sure to tick the box to add Python to PATH. If you already have Python installed and do not or are unsure if you have it added to PATH, see [here](https://realpython.com/add-python-to-path/) for a tutorial.

Next, open up a command prompt and run this command in it.

```
pip install atproto
```

After that, you should be good to go, download the latest release and extract it.

Run CaiSky.exe, and login, then you're free to post :)

# Known Problem(s)

Emojis just do not work, sometimes it posts some random Unicode symbols and sometimes it outright crashes the program.

# Credits

Thank you to:

Sego (https://bsky.app/profile/segalmandev.bsky.social) for the CaiSky name suggestion

