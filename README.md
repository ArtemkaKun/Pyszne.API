# What?

Pyszne.API - this is an open-source project, the main aim of which - create a user-friendly/robust, and performant API to communicate with the server of [Pyszne.pl](https://www.pyszne.pl/) service.

This project is split into 2 parts - a library that contains C# methods to wrap HTTP requests and a microservice, based on ASP.NET Core.

This library doesn't provide any hacks or backdoors of a [Pyszne.pl](https://www.pyszne.pl/) server and based on requests from a web browser. This library can only do what your web browser can do when you are doing any stuff on the [Pyszne.pl](https://www.pyszne.pl/) web page.

# Why?

For some reason, there is no public API for [Pyszne.pl](https://www.pyszne.pl/) service, so if you want to create a helper/bot/etc. to automate food booking, menu listing, or whatever, you are forced to create your implementation of API/parser.

I decided to create that kind of thing to automate the food buying process for a group of people and share this code with the community.

# How?

This project is based on the XHR data that can be found in the Development mode of your browser. So basically this lib can do anything (I hope) with [Pyszne.pl](https://www.pyszne.pl/) service that your web browser can. There is no high school math or any clever hacks, just implementation of requests from a web browser in C#.

# How to use?

If you want to embed a code of this project in your project - just build a DLL of a library part of this solution (Pyszne-API-lib project) or copy-paste all code that related to the Pyszne-API-lib project in this solution. The library part provides only wrappers for HTTP requests and returns raw JSON responses from the [Pyszne.pl](https://www.pyszne.pl/) server. All fancy stuff is in the microservice part.

![#c5f015](https://via.placeholder.com/15/c5f015/000000?text=+) `//TODO make wiki page with API solution doc`

If you want to use this project as a microservice - build the whole solution (that will build an ASP.NET Core server) and host wherever you want.

![#c5f015](https://via.placeholder.com/15/c5f015/000000?text=+) `//TODO make wiki page how to set up and configure ASP server and a doc for code`

# How to create new requests? How to get a HTTP request from a web browser to the Pyszne.pl server?

[Please, this that page of a wiki](https://github.com/ArtemkaKun/Pyszne.API/wiki/How-to-get-a-HTTP-request-from-a-web-browser-to-the-Pyszne.pl-server%3F)

# Disclaimer

Author of the Pyszne.API project - Artem Yurchenko.

This is an open-source free-to-use cost-free project. This project or its author does not have an aim to harm, hack or cause issues in the work of [Pyszne.pl](https://www.pyszne.pl/) service or its servers. 

Since the project is open source and anyone can add or modify its code, the author of the project does not responsible for any type of harm that can be caused for [Pyszne.pl](https://www.pyszne.pl/) service or its servers by the usage of this project.

Please, use this project at your own risk. The author of the project does not responsible for any claims from [Pyszne.pl](https://www.pyszne.pl/) service side to you.

If you are representing [Pyszne.pl](https://www.pyszne.pl/) service side and want to close/modify this project for whatever reason - please, contact me (Artem Yurchenko) via the email - artem.yurchenko.170500@gmail.com
