# dotnet-barcode
A simple example of an api in dotnet that provides data as well as consuming outside APIs.

## To Run (barcode)
- use visual studio to build the solution
	- build >> build solution
- use visual studio to run the solution
	- debug >> start debugging (F5)
- consume the barcode service
	-	http://localhost:5000/barcode/038000356216

## To Run (api consumers)
- get keys from rapidapi (urls listed below)
- add these keys to the appsettings.json file in the SimpleApi.API project
- use visual studio to build the solution
	- build >> build solution
- use visual studio to run the solution
	- debug >> start debugging (F5)

## Docker
- (from main project directory)
- docker build -t simpleapi:latest .
- docker run -p 5000:5000 simpleapi:latest


## Resources
- https://rapidapi.com/auth/sign-up?referral=/weatherapi/api/weatherapi-com/pricing
	- rapidapi free signup
- https://rapidapi.com/trueway/api/trueway-geocoding
	- 500 request / day (free)
- https://rapidapi.com/weatherapi/api/weatherapi-com/
	- 1000 requests / month (free)
- keys should be placed in appsettings.json file

