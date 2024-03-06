using System.Globalization;
using System.Resources;

namespace Fitomad.Guard.Resources;

sealed class GuardResourceManager
{
    private ResourceManager _resourceManager;
    private CultureInfo _currentCulture;

    internal string IsTrueMessage => _resourceManager.GetString("IsTrue", _currentCulture) ?? "";
    internal string IsFalseMessage => _resourceManager.GetString("IsFalse", _currentCulture) ?? "";
    
    internal string ContainsMessage => _resourceManager.GetString("Contains", _currentCulture) ?? "";
    internal string NotContainsMessage => _resourceManager.GetString("NotContains", _currentCulture) ?? "";
    internal string IsEmptyCollectionMessage => _resourceManager.GetString("IsEmpty", _currentCulture) ?? "";
    internal string NotEmptyCollectionMessage => _resourceManager.GetString("NotEmpty", _currentCulture) ?? "";
    
    internal string IsNull => _resourceManager.GetString("IsNull", _currentCulture) ?? "";
    internal string NotNull => _resourceManager.GetString("NotNull", _currentCulture) ?? "";
    internal string IsEquals => _resourceManager.GetString("IsEquals", _currentCulture) ?? "";
    internal string NotEquals => _resourceManager.GetString("NotEquals", _currentCulture) ?? "";

    internal string InRangeMessage => _resourceManager.GetString("InRange", _currentCulture) ?? "";
    internal string IsLower => _resourceManager.GetString("IsLower", _currentCulture) ?? "";
    internal string IsLowerOrEquals => _resourceManager.GetString("IsLowerOrEquals", _currentCulture) ?? "";
    internal string IsGreater => _resourceManager.GetString("IsGreater", _currentCulture) ?? "";
    internal string IsGreaterOrEquals => _resourceManager.GetString("IsGreaterOrEquals", _currentCulture) ?? "";

    internal string Match => _resourceManager.GetString("Match", _currentCulture) ?? "";
    internal string NotMatch => _resourceManager.GetString("NotMatch", _currentCulture) ?? "";

    internal string IsEmptyString => _resourceManager.GetString("IsEmptyString", _currentCulture) ?? "";
    internal string NotEmptyString => _resourceManager.GetString("NotEmptyString", _currentCulture) ?? "";
    internal string Length => _resourceManager.GetString("Length", _currentCulture) ?? "";
    internal string ContainsString => _resourceManager.GetString("ContainsString", _currentCulture) ?? "";
    internal string NotContainsString => _resourceManager.GetString("NotContainsString", _currentCulture) ?? "";
    internal string StartsWith => _resourceManager.GetString("StartsWith", _currentCulture) ?? "";
    internal string NotStartsWith => _resourceManager.GetString("NotStartsWith", _currentCulture) ?? "";
    internal string EndsWith => _resourceManager.GetString("EndsWith", _currentCulture) ?? "";
    internal string NotEndsWith => _resourceManager.GetString("NotEndsWith", _currentCulture) ?? "";

    internal GuardResourceManager()
    {
        _currentCulture = CultureInfo.CurrentCulture;  
        _resourceManager = new ResourceManager("Guard.Resources.Messages", typeof(GuardResourceManager).Assembly);
    }
}