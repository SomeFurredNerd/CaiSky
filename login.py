from atproto import Client

username = open("username.txt", "r")
password = open("password.txt", "r")

client = Client()
client.login(f'{username.read()}', f'{password.read()}')

# help = input()