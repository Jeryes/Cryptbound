/******************************************************************************/
//
//                             DO NOT MODIFY
//          This file has been generated by the UIElementsGenerator tool
//              See ShorthandApplicatorCsGenerator class for details
//
/******************************************************************************/
namespace UnityEngine.UIElements.StyleSheets
{
    internal static partial class ShorthandApplicator
    {
        public static void ApplyBorderColor(StylePropertyReader reader, ComputedStyle computedStyle)
        {
            CompileBoxArea(reader, out Color borderTopColor, out Color borderRightColor, out Color borderBottomColor, out Color borderLeftColor);

            computedStyle.nonInheritedData.borderTopColor = borderTopColor;
            computedStyle.nonInheritedData.borderRightColor = borderRightColor;
            computedStyle.nonInheritedData.borderBottomColor = borderBottomColor;
            computedStyle.nonInheritedData.borderLeftColor = borderLeftColor;
        }

        public static void ApplyBorderRadius(StylePropertyReader reader, ComputedStyle computedStyle)
        {
            CompileBorderRadius(reader, out Length borderTopLeftRadius, out Length borderTopRightRadius, out Length borderBottomRightRadius, out Length borderBottomLeftRadius);

            computedStyle.nonInheritedData.borderTopLeftRadius = borderTopLeftRadius;
            computedStyle.nonInheritedData.borderTopRightRadius = borderTopRightRadius;
            computedStyle.nonInheritedData.borderBottomRightRadius = borderBottomRightRadius;
            computedStyle.nonInheritedData.borderBottomLeftRadius = borderBottomLeftRadius;
        }

        public static void ApplyBorderWidth(StylePropertyReader reader, ComputedStyle computedStyle)
        {
            CompileBoxArea(reader, out float borderTopWidth, out float borderRightWidth, out float borderBottomWidth, out float borderLeftWidth);

            computedStyle.nonInheritedData.borderTopWidth = borderTopWidth;
            computedStyle.nonInheritedData.borderRightWidth = borderRightWidth;
            computedStyle.nonInheritedData.borderBottomWidth = borderBottomWidth;
            computedStyle.nonInheritedData.borderLeftWidth = borderLeftWidth;
        }

        public static void ApplyFlex(StylePropertyReader reader, ComputedStyle computedStyle)
        {
            CompileFlexShorthand(reader, out float flexGrow, out float flexShrink, out Length flexBasis);

            computedStyle.nonInheritedData.flexGrow = flexGrow;
            computedStyle.nonInheritedData.flexShrink = flexShrink;
            computedStyle.nonInheritedData.flexBasis = flexBasis;
        }

        public static void ApplyMargin(StylePropertyReader reader, ComputedStyle computedStyle)
        {
            CompileBoxArea(reader, out Length marginTop, out Length marginRight, out Length marginBottom, out Length marginLeft);

            computedStyle.nonInheritedData.marginTop = marginTop;
            computedStyle.nonInheritedData.marginRight = marginRight;
            computedStyle.nonInheritedData.marginBottom = marginBottom;
            computedStyle.nonInheritedData.marginLeft = marginLeft;
        }

        public static void ApplyPadding(StylePropertyReader reader, ComputedStyle computedStyle)
        {
            CompileBoxArea(reader, out Length paddingTop, out Length paddingRight, out Length paddingBottom, out Length paddingLeft);

            computedStyle.nonInheritedData.paddingTop = paddingTop;
            computedStyle.nonInheritedData.paddingRight = paddingRight;
            computedStyle.nonInheritedData.paddingBottom = paddingBottom;
            computedStyle.nonInheritedData.paddingLeft = paddingLeft;
        }

        public static void ApplyUnityTextOutline(StylePropertyReader reader, ComputedStyle computedStyle)
        {
            CompileTextOutline(reader, out Color unityTextOutlineColor, out float unityTextOutlineWidth);

            computedStyle.inheritedData.unityTextOutlineColor = unityTextOutlineColor;
            computedStyle.inheritedData.unityTextOutlineWidth = unityTextOutlineWidth;
        }
    }
}
