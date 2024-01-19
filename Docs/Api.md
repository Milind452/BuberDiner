# Buber Diner API

-   [Buber DinnerAPI](#buber-diner-api)
    -   [Auth](#auth)
        -   [Register](#register)
            -   [RegisterRequest](#register-request)
            -   [RegisterResponse](#register-response)
        -   [Login](#login)
            -   [LoginRequest](#login-request)
            -   [LoginResponse](#login-response)

## Auth

### Register

```js
POST {{host}}/auth/register
```

#### Register Request

```json
{
    "firstName": "Milind",
    "lastName": "Mohapatra",
    "email": "milind.mohapatra@gmail.com",
    "password": "Abcd@123"
}
```

#### Register Response

```js
200 OK
```

```json
{
    "id": "38b265d2-7e8e-4786-8f45-4b818dcb61ef",
    "firstName": "Milind",
    "lastName": "Mohapatra",
    "email": "milind.mohapatra@gmail.com",
    "token": "eyJhb..z9dpcnXoY"
}
```

### Login

```js
POST {{host}}/auth/login
```

#### Login Request

```json
{
    "email": "milind.mohapatra@gmail.com",
    "password": "Abcd@123"
}
```

#### Login Response

```js
200 OK
```

```json
{
    "id": "38b265d2-7e8e-4786-8f45-4b818dcb61ef",
    "firstName": "Milind",
    "lastName": "Mohapatra",
    "email": "milind.mohapatra@gmail.com",
    "token": "eyJhb..z9dpcnXoY"
}
```
