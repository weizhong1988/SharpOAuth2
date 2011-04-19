﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpOAuth2.Provider
{
    [Serializable]
    public class OAuthErrorResponseException<T> : Exception where T : class
    {
        public T Context{ get; private set; }
        public string Error { get; private set; }
        public Uri ErrorUri { get; private set; }
        public int HttpStatusCode { get; private set; }

        public OAuthErrorResponseException(T context, string error)
            : this()
        {
            Context = context;
            Error = error;
            HttpStatusCode = 400;
        }

        public OAuthErrorResponseException(T context, string error, string description = "", int httpStatusCode = 400, Uri errorUri = null)
            : this( description )
        {
            ErrorUri = errorUri;
            Error = error;
            Context = context;
            HttpStatusCode = httpStatusCode;
        }
        public OAuthErrorResponseException(T context, string error, string description, Exception inner, Uri errorUri = null)
            : this(description, inner)
        {
            ErrorUri = errorUri;
            Error = error;
            Context = context;
            HttpStatusCode = 400;
        }

        private OAuthErrorResponseException() { HttpStatusCode = 400; }
        private OAuthErrorResponseException(string message) : base(message) { HttpStatusCode = 400; }
        private OAuthErrorResponseException(string message, Exception inner) : base(message, inner) { HttpStatusCode = 400; }
        protected OAuthErrorResponseException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { HttpStatusCode = 400; }
    }
}
