using System;

namespace Web.Common
{
  [Serializable]
  public class UserLogin
  {
    public long UserID { set; get; }
    public string UserName { set; get; }
    public string GroupID { set; get; }
  }
}