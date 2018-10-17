﻿using System;
using Firebase.Storage;

namespace Plugin.FirebaseStorage
{
    public class FirebaseStorageImplementation : IFirebaseStorage
    {
        public IStorage Storage => new StorageWrapper(Firebase.Storage.Storage.DefaultInstance);

        public IStorage GetStorage(string url)
        {
            if (url == null)
                throw new ArgumentNullException(nameof(url));

            return new StorageWrapper(Firebase.Storage.Storage.From(url));
        }
    }
}
