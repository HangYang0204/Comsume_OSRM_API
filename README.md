# GeneXus_Training
1. __KB creation__ you can select language/framework you want to use (.NET Framework) about the version?
2. You can also specify your database conn informaion server_name and database_name. Otherwise you have to specify this when build.
3. __Transaction__ creation, it creates a transaction obj and web panel object.
4. What is a transaction? it consists of a table + webform and other functional options like (rules, patterns and variables etc.)
5. The webform readily available with Add + Update + Delete and even a Select.
6. Define __attributes(att.)__ for transaction. Att type ( key, primary, secendary, __subtype__/foreigh key, subtype/inferal, fomula applied, semantic like photo..)
7. __Domains__. User/system defined Class with customized properties. You can add from Domain window or just put inline when create att.
8. __Semantic domain__ includes Address, Phone and Email. user domain we created are Name, Id(we tried Autonumber = true), SeatChar (we tried Enum Values) etc.
9. __Levels__. There are 2 use cases to create level, Strong entity v.s. Weak entity, we create Weak entity as level of the Strong entity. A good example is that flight v.s. flight seat. Seat only makes sense in the existance of the flight it self. The second case is to create a many to many relationship, in this case, GeneXus is always create 3 tables the example we use is Suppliers and Attractions. Attraction (1) -> SupplierAttrication(N) -> Supplier (1) which can be observed in diagram.
10. Added Levels would also appear in the webform as a grid includes the list(N) to show the 1-N relathionship. The level also always have composed parimary key level 1 id + level 2 id
11. Att. Name convension is following EntityName + level/Qualifier + Semantic Category. An example is AttractionAddedDate.
12. __Pattern__. an easy way to add some feature like filtering, sorting, pagenation, insert, delete, update etc...
13. It does create pattern objects that is dynamically linked with the transaction. If you delete any of these object you will break the connection, to restore, go to Edit-> Apply Default. This is a not reconmended use of this.
14.  Extended tables is to starting from base table follow N-1 until no more 1 to be found.
15.  __Subtyle__ is a way to get GeneXus to connect 2 attrubutes with different name. GeneXus is smart to connect att. with same name using foreigh key constrain. In use case of flight Departure airport and flight Arrival airport, we define Subtype FlightDepartureAirportId(sublevel) -> AirportId (super level).
16. __Rules__ we can also define rules in the transaction some example we tried are Error, Msg, noaccept etc. and of course conditions IF OHTERWISE. One thing to notice is that the execution is not by the order of the statement written. I also noticed Pattern would also auto generate some rules.
17. __Formula__  two types of formula are talked both are inline, one is horizontal fomula (+ - * /) the other is aggregate formula(count, sum...).
18. Triggering order of the rules, __On afterlevel <level att.>__ is to make sure you can type all the sublevel list(specified with level att.) before triggering the rules. A use case we have is count the seat, we want to make sure it is more than 8 for the flight, so if not using the afterlevel hint, it will throw error when you still typing in data. With it, the rule is triggered when you click confirm.

## Comsuming OSRM backend code
refer to this project https://github.com/Project-OSRM/osrm-backend.git
and this document https://project-osrm.org/docs/v5.5.1/api/#nearest-service
