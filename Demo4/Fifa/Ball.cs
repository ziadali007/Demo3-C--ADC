using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4.Fifa
{
    internal class Ball
    {
        public int Id { get; set; }

        private Location location;

        public Action<Ball> BallLocationChange;

        public Location Location
        {
            get { return location; }
            set {

                if (!location.Equals(value))
                {
                    location = value;
                    if (BallLocationChange is not null)
                        BallLocationChange.Invoke(this);
                }

            }
        }

        
        public override string ToString()
        {
            return $"Id: {Id} Location: {Location}";
        }
    }
}
