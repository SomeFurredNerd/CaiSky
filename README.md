
# CaiSky

A personal project I made to get accustomed to Visual Studio 2022 to get ready for the course I'm taking this year.

This is a C# WinForms project that uses the Python Bluesky API to login and post. Originally it wasn't really meant to be a public project, but it kind of morphed into some version of a bluesky alternative to the delegate system on Twitter, but due to my inexperience I can't reaallyy make it as secure as I would like, which leads me to the disclaimer.

# Disclaimer

This project stores the username and password in PLAINTEXT. This is NOT VERY SECURE, so please do not use this on any sort of shared machine, or anywhere where someone could access the directory CaiSky is saved to. I couldn't quite figure out a way to encrypt it in a way that it couldn't be easily reversed, if anyone has ideas or wants to contribute, that would be greatly appreciated :)

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

