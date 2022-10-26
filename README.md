Caching in .NET Core 

What is Caching?

The cache is the memory storage that is used to store the frequent access data into the temporary storage, it will improve the performance drastically and avoid the unnecessary database hit and store frequently used data into the buffer whenever we need it.

![image](https://user-images.githubusercontent.com/85872541/198105592-0eade01d-a502-49d4-89bd-364b51a71d27.png)

![image](https://user-images.githubusercontent.com/85872541/198105628-98be5628-f600-4bb4-880c-39be7351948e.png)



Types of Cache

Basically, there are two types of caching .NET Core supports:
1.	In-Memory Caching (This stores data on the application server memory)
2.	Distributed Caching (This stores data on an external service that multiple application servers can share)

In-Memory Cache

Basically, In-Memory Cache is used for lightweight and small applications and that will work well in that. It stores data into the server memory on the application side and users use that whenever need arises.

Advantages of In-Memory Cache

•	Users fetch data rapidly when we use In-Memory Cache.

•	It will increase the performance of the application.

•	Best suited for small application which is deployed on a single server.


Disadvantages of In-Memory Cache

•	Sometimes In-Memory cache increases the maintenance of the application

•	In the In-Memory Cache data is persisted on a single server and if the server will crash then data is lost

•	If we stop the server, all the data that we cache in-memory will lose because it is in-memory cache.

•	Also it’s hard to scale the application in some scenarios.
