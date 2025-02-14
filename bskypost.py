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

data = client.get_author_feed(
    actor=username,
    filter='posts_and_author_threads',
    limit=1,
) 



data = str(data)

print(data)

startpostindex = data.find("post/")
endpostindex = data.find("'", startpostindex)

post = data[startpostindex:endpostindex]
posta,postb = post.split("/")

#print(post)
#print(posta)
#print(postb)

with open("postlink.txt", "w") as file:
    file.write(f"https://bsky.app/profile/{username}/post/{postb}")


