# ListPostRepro
Project to Repro Potential Issue with Simple.OData.Client

When an object contains a List of Objects, if the Object Type of the List is the same as an entity defined in the EDMModel, then Simple.OData creates the URL to pass the object in the JSON body instead of the serializing the object.
