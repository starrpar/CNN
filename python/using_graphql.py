
import requests

query = """
{
    rockets {
        name
        boosters
        engines {
            type
            propellant_1
            engine_loss_max
        }
    }
}
"""
headers = {'Content-type': 'x-apollo-operation-name'}
response = requests.get("https://spacex-production.up.railway.app/", params={"query": query}, headers=headers)

data = response.json()
print(data)

# response data:
# {'data': 
#     {'rockets': [
#         {'name': 'Falcon 1', 'boosters': 0, 'engines': 
#          {'type': 'merlin', 'propellant_1': 'liquid oxygen', 'engine_loss_max': '0'}
#         }, 
#         {'name': 'Falcon 9', 'boosters': 0, 'engines': 
#          {'type': 'merlin', 'propellant_1': 'liquid oxygen', 'engine_loss_max': '2'}
#         }, 
#         {'name': 'Falcon Heavy', 'boosters': 2, 'engines': 
#          {'type': 'merlin', 'propellant_1': 'liquid oxygen', 'engine_loss_max': '6'}
#         }, 
#         {'name': 'Starship', 'boosters': 0, 'engines': 
#          {'type': 'raptor', 'propellant_1': 'liquid oxygen', 'engine_loss_max': None}
#         }]
#     }
# }


def use_graphql():

    print("do nothing yet")