function TabOver(tabElement, tabNumber)
{
    tabElement.className = "NavTabOver Tab" + tabNumber;
}

function TabOut(tabElement, tabNumber)
{
    tabElement.className = "NavTab Tab" + tabNumber;
}

function MenuOver(menuElement, tabLevel)
{    
    menuElement.className = "MenuItemOver Level" + tabLevel;
}

function MenuOut(menuElement, tabLevel)
{
    menuElement.className = "MenuItem Level" + tabLevel;
}

function SpecialOfferGridClick(uri)
{
    document.location.href = uri;
}

function SpecialOfferGridOver(row)
{
    row.className = "specialOfferOver";
}

function SpecialOfferGridOut(row)
{
    row.className = "";
}

function CreateTabOverHandler(element, index)
{
    return function()
    {
        return TabOver(element, index);
    }
}

function CreateTabOutHandler(element, index)
{
    return function()
    {
        return TabOut(element, index);
    }
}

function CreateMenuOverHandler(element, level)
{
    return function()
    {
        return MenuOver(element, level);
    }
}

function CreateMenuOutHandler(element, level)
{
    return function()
    {
        return MenuOut(element, level);
    }
}