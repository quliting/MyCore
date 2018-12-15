using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstProject.Model
{
    public class UserProperty
    {
        private int? _requestHashCode;
        public int AppUserId { get; set; }
        public string Key { get; set; }
        public string Text { get; set; }
        public string Value { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is UserProperty))
            {
                return false;
            }

            if (object.ReferenceEquals(this, obj))
            {
                return true;
            }

            UserProperty item = (UserProperty)obj;

            if (item.IsTranisent() || this.IsTranisent())
            {
                return false;
            }
            else
            {
                return item.Key == Key && item.Value == Value;
            }
        }

        public override int GetHashCode()
        {
            if (!IsTranisent())
            {
                if (!_requestHashCode.HasValue)
                {
                    _requestHashCode = (this.Key + this.Value).GetHashCode() ^ 31;
                }

                return _requestHashCode.Value;
            }
            else
            {
                return base.GetHashCode();
            }
        }

        /// <summary>
        /// 值或者Value 是否有一个为空
        /// </summary>
        /// <returns></returns>
        private bool IsTranisent()
        {
            return string.IsNullOrEmpty(Key) || string.IsNullOrEmpty(Value);
        }
    }
}
