using System;
using System.Collections.Generic;

internal class InventoryUtility
{
    /// <summary>
    /// this is InventoryUtility
    /// </summary>
        /// <summary>
        /// Gets or sets the rice list.
        /// </summary>
        /// <value>
        /// The rice list.
        /// </value>
        public List<Rice> RiceList { get; set; }

        /// <summary>
        /// Gets or sets the pulse list.
        /// </summary>
        /// <value>
        /// The pulse list.
        /// </value>
        public List<Pulse> PulseList { get; set; }

        /// <summary>
        /// Gets or sets the List
        /// </summary>
        /// <value>
        /// The list.
        /// </value>
        public List<Wheats> WheatsList { get; set; }

        /// <summary>
        /// this is class.
        /// </summary>
        public class Wheats
        {
            /// <summary>
            /// Gets or sets the name.
            /// </summary>
            /// <value>
            /// The name.
            /// </value>
            public string Name { get; set; }

            /// <summary>
            /// Gets or sets the price.
            /// </summary>
            /// <value>
            /// The price.
            /// </value>
            public int Price { get; set; }

            /// <summary>
            /// Gets or sets the kg.
            /// </summary>
            /// <value>
            /// The kg.
            /// </value>
            public int Kg { get; set; }

            /// <summary>
            /// Gets or sets the type.
            /// </summary>
            /// <value>
            /// The type.
            /// </value>
            public string Type { get; set; }

            public void SomethingMethod()
            {
                int x = 10;
            System.Console.WriteLine(x);
            }
        }

        /// <summary>
        /// this is class Pulse
        /// </summary>
        public class Pulse
        {
            /// <summary>
            /// Gets or sets the name.
            /// </summary>
            /// <value>
            /// The name.
            /// </value>
            public string Name { get; set; }

            /// <summary>
            /// Gets or sets the price.
            /// </summary>
            /// <value>
            /// The price.
            /// </value>
            public int Price { get; set; }

            /// <summary>
            /// Gets or sets the kg.
            /// </summary>
            /// <value>
            /// The kg.
            /// </value>
            public int Kg { get; set; }

            /// <summary>
            /// Gets or sets the type.
            /// </summary>
            /// <value>
            /// The type.
            /// </value>
            public string Type { get; set; }
        }

        /// <summary>
        /// this is Rice class.
        /// </summary>
        public class Rice
        {
            /// <summary>
            /// Gets or sets the name.
            /// </summary>
            /// <value>
            /// The name.
            /// </value>
            public string Name { get; set; }

            /// <summary>
            /// Gets or sets the price.
            /// </summary>
            /// <value>
            /// The price.
            /// </value>
            public int Price { get; set; }

            /// <summary>
            /// Gets or sets the kg.
            /// </summary>
            /// <value>
            /// The kg.
            /// </value>
            public int Kg { get; set; }

            /// <summary>
            /// Gets or sets the type.
            /// </summary>
            /// <value>
            /// The type.
            /// </value>
            public string Type { get; set; }

            public static explicit operator int(Rice v)
            {
                throw new NotImplementedException();
            }
        }
    }

    public class Rice
    {
        public string Name { get; internal set; }
        public int Price { get; internal set; }
        public int Kg { get; internal set; }
        public string Type { get; internal set; }
    }

    public class Pulse
    {
        public string Name { get; internal set; }
        public int Price { get; internal set; }
        public int Kg { get; internal set; }
        public string Type { get; internal set; }
    }

    public class Wheats
    {
        public string Name { get; internal set; }
        public int Price { get; internal set; }
        public int Kg { get; internal set; }
        public string Type { get; internal set; }
    }
