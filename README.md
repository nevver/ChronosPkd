**Chronos Public Key Distribution API ![icon](https://github.com/nevver/ChronosClient/blob/master/ChronosClient/Assets/Square44x44Logo.targetsize-24_altform-unplated.png?raw=true)**
====
ASP.NET PKD API. <br />
The accompanying Ruby on Rails RESTful web messenger API is https://github.com/nevver/ChronosApi. <br />
The UWP client repo is  https://github.com/nevver/chronosclient. <br>

**Register a Public Key**
----

  Submit a public key to the PKD. Returns status code 400 for bad or duplicate requests.

* **URL**

  `/api/PublicKey`

* **Method:**

  `POST`
  
*  **URL Params**

   **Required:**

   None

* **Data Params**
  * **Body:**
   `{"user":"string", "key": "string"}`

* **Success Response:**

  * **Code:** 200 <br />
 
* **Error Response:**

  * **Code:** 400 <br />

**Find Public Key by Username**
----

  Request a user's public key by username.

* **URL**

  `/api/PublicKey/byUser`

* **Method:**

  `GET`
  
*  **URL Params**

   **Required:**
 
   `?user={username}`

* **Data Params**
  * **Body:**

   None

* **Success Response:**

  * **Code:** 200 <br />
 
* **Error Response:**

  * **Code:** 404 <br />

