from atproto import Client
import os, base64

osplatform = os.name

if osplatform == "nt":
    user64 = os.environ.get("csuser")
    pass64 = os.environ.get("cspass")
    username = base64.b64decode(user64).decode("utf-8")
    password = base64.b64decode(pass64).decode("utf-8")
else:
    username = open("username.txt", "r")
    password = open("password.txt", "r")


# with open("debug.txt", "w") as file:
#    file.write(f"{user64}, {pass64}, {username}, {password}") 



client = Client()

if osplatform == "nt":
    client.login(username, password)
else: 
    client.login(f'{username.read()}', f'{password.read()}')
