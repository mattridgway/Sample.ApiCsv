# API to CSV

This simple site uses JavaScript and HTML5 to query an API, format the repsonse as CSV (instead of JSON) and then force the browser to download that formatted response as a file.

## JavaScript

This site uses the following JavaScript APIs:

* [Fetch](https://developer.mozilla.org/en-US/docs/Web/API/Fetch_API/Using_Fetch) to query the API
* [Blob](https://developer.mozilla.org/en-US/docs/Web/API/Blob) to hold the CSV data
* [URL.createObjectURL](https://developer.mozilla.org/en-US/docs/Web/API/URL/createObjectURL) to create a URL for the blob

## HTML5

This site also uses the following HTML5 elements:

* [A.download](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/a#Attributes) to force the browser to download rather than visit a URL

## Running

To run this site locally you will need [.NET Core](https://dotnet.microsoft.com/download) installed. Then open a command prompt in the `/src/Sample.ApiCsv.Web` folder and run the command `dotnet run`. Following that the site will be running and can be accessed using [https://localhost:5001](https://localhost:5001).