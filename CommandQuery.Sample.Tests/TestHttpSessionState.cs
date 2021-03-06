﻿using System.Collections;
using System.Collections.Specialized;
using System.Web;
using System.Web.SessionState;

namespace CommandQuery.Sample.Tests
{
    public class TestHttpSessionState : HttpSessionStateBase
    {
        // Fields
        private readonly SessionStateItemCollection sessionItems;

        // Methods
        public TestHttpSessionState(SessionStateItemCollection sessionItems)
        {
            this.sessionItems = sessionItems;
        }

        public override void Add(string name, object value)
        {
            sessionItems[name] = value;
        }

        public override IEnumerator GetEnumerator()
        {
            return sessionItems.GetEnumerator();
        }

        public override void Remove(string name)
        {
            sessionItems.Remove(name);
        }

        // Properties
        public override int Count
        {
            get
            {
                return sessionItems.Count;
            }
        }

        public override object this[string name]
        {
            get
            {
                return sessionItems[name];
            }
            set
            {
                sessionItems[name] = value;
            }
        }

        public override object this[int index]
        {
            get
            {
                return sessionItems[index];
            }
            set
            {
                sessionItems[index] = value;
            }
        }

        public override NameObjectCollectionBase.KeysCollection Keys
        {
            get
            {
                return sessionItems.Keys;
            }
        }
    }
}