using System.Globalization;
using System.Resources;

namespace Fitomad.Guard.Resources;

sealed class GuardResourceManager
{
    private ResourceManager _resourceManager;
    private CultureInfo _currentCulture;

    internal string IsTrueMessage => _resourceManager.GetString("IsTrue", _currentCulture) ?? "";
    internal string IsFalseMessage => _resourceManager.GetString("IsFalse", _currentCulture) ?? "";
    
    internal string InRangeMessage => _resourceManager.GetString("InRange", _currentCulture) ?? "";
    internal string IsLower => _resourceManager.GetString("IsLower", _currentCulture) ?? "";
    internal string IsLowerOrEquals => _resourceManager.GetString("IsLowerOrEquals", _currentCulture) ?? "";
    internal string IsGreater => _resourceManager.GetString("IsGreater", _currentCulture) ?? "";
    internal string IsGreaterOrEquals => _resourceManager.GetString("IsGreaterOrEquals", _currentCulture) ?? "";


    internal GuardResourceManager()
    {
        _currentCulture = CultureInfo.CurrentCulture;  
        _resourceManager = new ResourceManager("Guard.Resources.Messages", typeof(GuardResourceManager).Assembly);
    }
}