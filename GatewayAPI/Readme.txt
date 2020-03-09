Intall Ocelot nuget package
https://ocelot.readthedocs.io/en/latest/features/routing.html

Example
"DownstreamPathTemplate": "/api/{catchAll}",
      "DownstreamScheme": "http",
      "DownstreamHostAndPorts": [
        {
          "Host": "localhost",
          "Port": 7001
        }
      ],
      "UpstreamPathTemplate": "/catalog-api/{catchAll}" --User exposed URL, whenever call comes to this URL, redirect it to port 7001
    },


To access Catalog API
http://localhost:7000/catalog-api/catalog

To access Order API
http://localhost:7000/order-api/order
