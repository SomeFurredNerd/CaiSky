from atproto import Client


bskypost = open("bskypost.txt", "r")
username = open("username.txt", "r")
password = open("password.txt", "r")

client = Client()
client.login(f'{username.read()}', f'{password.read()}')

post = client.send_post(bskypost.read())