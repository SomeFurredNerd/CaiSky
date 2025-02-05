from atproto import Client
import os, base64

osplatform = os.name

bskypost = open("bskypost.txt", "r")

if osplatform == "nt":
    user64 = os.environ.get("csuser")
    pass64 = os.environ.get("cspass")
    username = base64.b64decode(user64).decode("utf-8")
    password = base64.b64decode(pass64).decode("utf-8")
else:
    username = open("username.txt", "r")
    password = open("password.txt", "r")

client = Client()
if osplatform == "nt":

    client.login(username, password)
else: 
    client.login(f'{username.read()}', f'{password.read()}')

post = client.send_post(bskypost.read())