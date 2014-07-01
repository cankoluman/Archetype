Archetype-Serialization
=======================

Archetype Serialization
This project aims to provide a serialzier / deserializer for the excellent Archetype package for Umbraco: https://github.com/imulus/Archetype.
 
Background : It all started off as a fork of the Archetype project. The initial idea was to create a serializer that lived inside the Archetype project. However, the serializer will now be living outside of the official Archetype project. 

The reasons behind the change are the complexity of the serializer and well as some reports of data loss, that might have been caused by the serializer's delinter.

I have not been able to replicate any data loss scenarios and would be grateful for any feedback - in particular 'before' and 'after' jsons strings for the affected data if available.

In any case, the basic plan is to start with the deserializer first (i.e. read only functionality), and then progress to the serializer (write).

In separating the project, the serializer will no longer have access to the internal calls in 'Archetype', but I am hoping that this will actually be a positive factor. For json reads we would only need the Models. However json writes are a litle more complex.

Also, as a result of the separation, we are possibly introducing the potential for breaking changes. However, I will attempt to control these by using version checking.

For anybody who wants to play with a version of Archetype that contains the serializer, you can have a look at my original fork here: https://github.com/cankoluman/Archetype/tree/stable. However, development in this fork will cease.

