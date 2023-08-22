using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp4
{
    public class Group
    {
        public string QuestionGroupID { get; set; }
        public string QuestionGroupCode { get; set; }
        public string QuestionGroupName { get; set; }
        public object QuestionGroupDescription { get; set; }
        public object ParentQuestionGroupID { get; set; }
        public object IdentifierQuestionID { get; set; }
        public bool HasContent { get; set; }
        public bool HasNote { get; set; }
        public bool HasAction { get; set; }
        public bool Expandable { get; set; }
        public bool InitiallyOpen { get; set; }
        public bool IsRepeated { get; set; }
        public int MaxRepeatCount { get; set; }
        public int ColumnCount { get; set; }
        public string Direction { get; set; }
        public int SortOrder { get; set; }
        public List<Question> Questions { get; set; }
    }

    public class Question
    {
        public string QuestionID { get; set; }
        public string QuestionCode { get; set; }
        public string QuestionName { get; set; }
        public object QuestionDescription { get; set; }
        public string QuestionClassCode { get; set; }
        public string QuestionDataTypeCode { get; set; }
        public string QuestionComponentTypeCode { get; set; }
        public bool Required { get; set; }
        public bool DataRequired { get; set; }
        public bool MultipleSelection { get; set; }
        public object LowerControlLimit { get; set; }
        public object UpperControlLimit { get; set; }
        public object MinValue { get; set; }
        public object MaxValue { get; set; }
        public object ExpectedValue { get; set; }
        public bool AllowNotAvailable { get; set; }
        public bool HasContent { get; set; }
        public bool HasNote { get; set; }
        public bool HasAction { get; set; }
        public bool HasDescription { get; set; }
        public int SortOrder { get; set; }
        public List<ValueList> ValueList { get; set; }
    }

    public class QuestionList
    {
        public string QuestionListID { get; set; }
        public string QuestionListCode { get; set; }
        public string QuestionListName { get; set; }
        public object QuestionListDescription { get; set; }
        public string QuestionClassCode { get; set; }
        public string QuestionClassName { get; set; }
        public string QuestionListGroupCode { get; set; }
        public string QuestionListGroupName { get; set; }
        public string SiteID { get; set; }
        public bool HasMaterial { get; set; }
        public bool HasProductInstance { get; set; }
        public bool HasContent { get; set; }
        public bool HasNote { get; set; }
        public bool HasAction { get; set; }
        public int GroupLevel { get; set; }
        public int SortOrder { get; set; }
        public List<Section> Sections { get; set; }
    }

    public class Root
    {
        public List<QuestionList> QuestionList { get; set; }
    }

    public class Section
    {
        public string QuestionListSectionCode { get; set; }
        public List<Group> Groups { get; set; }
    }

    public class ValueList
    {
        public string ValueListID { get; set; }
        public string ValueListCode { get; set; }
        public string ValueListName { get; set; }
        public string QuestionDataTypeCode { get; set; }
        public object ButtonCountPerLine { get; set; }
        public object ButtonWidth { get; set; }
        public object ValueListItemGroups { get; set; }
        public List<ValueListItem> ValueListItems { get; set; }
    }

    public class ValueListItem
    {
        public string ValueListItemID { get; set; }
        public string Value { get; set; }
        public string DisplayText { get; set; }
        public object BackColor { get; set; }
        public object ForeColor { get; set; }
        public object ValueClassCode { get; set; }
        public object ImageData { get; set; }
        public object ParentValueListItemID { get; set; }
        public object ValueListItemGroupID { get; set; }
        public int SortOrder { get; set; }
    }

}
