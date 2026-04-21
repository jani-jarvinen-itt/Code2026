import requests

url = "https://jsonplaceholder.typicode.com/users"
response = requests.get(url)

if response.status_code == 200:
    data = response.json()
    for user in data:
        print(f"Nimi: {user['name']}, katu: {user['address']['street']}")
