using System.Collections.Generic;

namespace ZagsReverseConnection.API.Models
{
    public class GetFamilyModel
    {
        public int id { get; set; }
        public string direction { get; set; }
        public List<Detail> details { get; set; }
        public List<List<string>> ref_regions { get; set; }
        public List<List<string>> ref_branches { get; set; }
        public List<List<string>> ref_genders { get; set; }
        public List<List<string>> ref_traversals { get; set; }
        public List<List<string>> ref_events { get; set; }
        public List<List<string>> ref_actions { get; set; }
        public int result_code { get; set; }
        public object result_message { get; set; }
        public object task_state { get; set; }
        public object task_message { get; set; }
        public Form_Completion_Advices form_completion_advices { get; set; }
        public string PinFL { get; set; }
        public string Change { get; set; }
    }
}
public class Form_Completion_Advices
{
    public WHOSE WHOSE { get; set; }
    public APPEND APPEND { get; set; }
    public EXISTING EXISTING { get; set; }
    public CREATE CREATE { get; set; }
}

public class WHOSE
{
    public string[] HUSBAND { get; set; }
    public string[] MOTHER { get; set; }
    public string[] DAUGHTER { get; set; }
    public string[] SELF { get; set; }
    public string[] FATHER { get; set; }
    public string[] SISTER { get; set; }
    public string[] BROTHER { get; set; }
    public string[] WIFE { get; set; }
    public string[] SON { get; set; }
}

public class APPEND
{
    public HUSBAND HUSBAND { get; set; }
    public MOTHER MOTHER { get; set; }
    public DAUGHTER DAUGHTER { get; set; }
    public SELF SELF { get; set; }
    public FATHER FATHER { get; set; }
    public SISTER SISTER { get; set; }
    public BROTHER BROTHER { get; set; }
    public WIFE WIFE { get; set; }
    public SON SON { get; set; }
}

public class HUSBAND
{
    public DIVORCED DIVORCED { get; set; }
    public DEAD DEAD { get; set; }
}

public class DIVORCED
{
    public string certOf { get; set; }
}

public class DEAD
{
    public string certOf { get; set; }
}

public class MOTHER
{
    public DEAD1 DEAD { get; set; }
    public MARRIED MARRIED { get; set; }
    public DIVORCED1 DIVORCED { get; set; }
}

public class DEAD1
{
    public string certOf { get; set; }
}

public class MARRIED
{
    public string certOf { get; set; }
}

public class DIVORCED1
{
    public string certOf { get; set; }
}

public class DAUGHTER
{
    public DEAD2 DEAD { get; set; }
    public MARRIED1 MARRIED { get; set; }
    public DIVORCED2 DIVORCED { get; set; }
}

public class DEAD2
{
    public string certOf { get; set; }
}

public class MARRIED1
{
    public string certOf { get; set; }
}

public class DIVORCED2
{
    public string certOf { get; set; }
}

public class SELF
{
    public DEAD3 DEAD { get; set; }
    public MARRIED2 MARRIED { get; set; }
    public DIVORCED3 DIVORCED { get; set; }
}

public class DEAD3
{
    public string certOf { get; set; }
}

public class MARRIED2
{
    public string certOf { get; set; }
}

public class DIVORCED3
{
    public string certOf { get; set; }
}

public class FATHER
{
    public DEAD4 DEAD { get; set; }
    public MARRIED3 MARRIED { get; set; }
    public DIVORCED4 DIVORCED { get; set; }
}

public class DEAD4
{
    public string certOf { get; set; }
}

public class MARRIED3
{
    public string certOf { get; set; }
}

public class DIVORCED4
{
    public string certOf { get; set; }
}

public class SISTER
{
    public DEAD5 DEAD { get; set; }
    public MARRIED4 MARRIED { get; set; }
    public DIVORCED5 DIVORCED { get; set; }
}

public class DEAD5
{
    public string certOf { get; set; }
}

public class MARRIED4
{
    public string certOf { get; set; }
}

public class DIVORCED5
{
    public string certOf { get; set; }
}

public class BROTHER
{
    public DEAD6 DEAD { get; set; }
    public MARRIED5 MARRIED { get; set; }
    public DIVORCED6 DIVORCED { get; set; }
}

public class DEAD6
{
    public string certOf { get; set; }
}

public class MARRIED5
{
    public string certOf { get; set; }
}

public class DIVORCED6
{
    public string certOf { get; set; }
}

public class WIFE
{
    public DIVORCED7 DIVORCED { get; set; }
    public DEAD7 DEAD { get; set; }
}

public class DIVORCED7
{
    public string certOf { get; set; }
}

public class DEAD7
{
    public string certOf { get; set; }
}

public class SON
{
    public DEAD8 DEAD { get; set; }
    public MARRIED6 MARRIED { get; set; }
    public DIVORCED8 DIVORCED { get; set; }
}

public class DEAD8
{
    public string certOf { get; set; }
}

public class MARRIED6
{
    public string certOf { get; set; }
}

public class DIVORCED8
{
    public string certOf { get; set; }
}

public class EXISTING
{
    public AS_WIFE AS_WIFE { get; set; }
    public AS_HUSBAND AS_HUSBAND { get; set; }
    public DAUGHTER1 DAUGHTER { get; set; }
    public WIFE1 WIFE { get; set; }
    public FATHER1 FATHER { get; set; }
    public SON1 SON { get; set; }
    public SELF1 SELF { get; set; }
    public BROTHER1 BROTHER { get; set; }
    public SISTER1 SISTER { get; set; }
    public MOTHER1 MOTHER { get; set; }
    public HUSBAND1 HUSBAND { get; set; }
}

public class AS_WIFE
{
    public DEAD9 DEAD { get; set; }
    public DIVORCED9 DIVORCED { get; set; }
    public BORN BORN { get; set; }
    public MARRIED7 MARRIED { get; set; }
}

public class DEAD9
{
    public string certOf { get; set; }
}

public class DIVORCED9
{
    public string certOf { get; set; }
}

public class BORN
{
    public string certOf { get; set; }
}

public class MARRIED7
{
    public string certOf { get; set; }
}

public class AS_HUSBAND
{
    public DEAD10 DEAD { get; set; }
    public DIVORCED10 DIVORCED { get; set; }
    public BORN1 BORN { get; set; }
    public MARRIED8 MARRIED { get; set; }
}

public class DEAD10
{
    public string certOf { get; set; }
}

public class DIVORCED10
{
    public string certOf { get; set; }
}

public class BORN1
{
    public string certOf { get; set; }
}

public class MARRIED8
{
    public string certOf { get; set; }
}

public class DAUGHTER1
{
    public DEAD11 DEAD { get; set; }
    public DIVORCED11 DIVORCED { get; set; }
    public BORN2 BORN { get; set; }
    public MARRIED9 MARRIED { get; set; }
}

public class DEAD11
{
    public string certOf { get; set; }
}

public class DIVORCED11
{
    public string certOf { get; set; }
}

public class BORN2
{
    public string certOf { get; set; }
}

public class MARRIED9
{
    public string certOf { get; set; }
}

public class WIFE1
{
    public DEAD12 DEAD { get; set; }
    public DIVORCED12 DIVORCED { get; set; }
    public BORN3 BORN { get; set; }
    public MARRIED10 MARRIED { get; set; }
}

public class DEAD12
{
    public string certOf { get; set; }
}

public class DIVORCED12
{
    public string certOf { get; set; }
}

public class BORN3
{
    public string certOf { get; set; }
}

public class MARRIED10
{
    public string certOf { get; set; }
}

public class FATHER1
{
    public DEAD13 DEAD { get; set; }
    public DIVORCED13 DIVORCED { get; set; }
    public BORN4 BORN { get; set; }
    public MARRIED11 MARRIED { get; set; }
}

public class DEAD13
{
    public string certOf { get; set; }
}

public class DIVORCED13
{
    public string certOf { get; set; }
}

public class BORN4
{
    public string certOf { get; set; }
}

public class MARRIED11
{
    public string certOf { get; set; }
}

public class SON1
{
    public DEAD14 DEAD { get; set; }
    public DIVORCED14 DIVORCED { get; set; }
    public BORN5 BORN { get; set; }
    public MARRIED12 MARRIED { get; set; }
}

public class DEAD14
{
    public string certOf { get; set; }
}

public class DIVORCED14
{
    public string certOf { get; set; }
}

public class BORN5
{
    public string certOf { get; set; }
}

public class MARRIED12
{
    public string certOf { get; set; }
}

public class SELF1
{
    public DEAD15 DEAD { get; set; }
    public DIVORCED15 DIVORCED { get; set; }
    public BORN6 BORN { get; set; }
    public MARRIED13 MARRIED { get; set; }
}

public class DEAD15
{
    public string certOf { get; set; }
}

public class DIVORCED15
{
    public string certOf { get; set; }
}

public class BORN6
{
    public string certOf { get; set; }
}

public class MARRIED13
{
    public string certOf { get; set; }
}

public class BROTHER1
{
    public DEAD16 DEAD { get; set; }
    public DIVORCED16 DIVORCED { get; set; }
    public BORN7 BORN { get; set; }
    public MARRIED14 MARRIED { get; set; }
}

public class DEAD16
{
    public string certOf { get; set; }
}

public class DIVORCED16
{
    public string certOf { get; set; }
}

public class BORN7
{
    public string certOf { get; set; }
}

public class MARRIED14
{
    public string certOf { get; set; }
}

public class SISTER1
{
    public DEAD17 DEAD { get; set; }
    public DIVORCED17 DIVORCED { get; set; }
    public BORN8 BORN { get; set; }
    public MARRIED15 MARRIED { get; set; }
}

public class DEAD17
{
    public string certOf { get; set; }
}

public class DIVORCED17
{
    public string certOf { get; set; }
}

public class BORN8
{
    public string certOf { get; set; }
}

public class MARRIED15
{
    public string certOf { get; set; }
}

public class MOTHER1
{
    public DEAD18 DEAD { get; set; }
    public DIVORCED18 DIVORCED { get; set; }
    public BORN9 BORN { get; set; }
    public MARRIED16 MARRIED { get; set; }
}

public class DEAD18
{
    public string certOf { get; set; }
}

public class DIVORCED18
{
    public string certOf { get; set; }
}

public class BORN9
{
    public string certOf { get; set; }
}

public class MARRIED16
{
    public string certOf { get; set; }
}

public class HUSBAND1
{
    public DEAD19 DEAD { get; set; }
    public DIVORCED19 DIVORCED { get; set; }
    public BORN10 BORN { get; set; }
    public MARRIED17 MARRIED { get; set; }
}

public class DEAD19
{
    public string certOf { get; set; }
}

public class DIVORCED19
{
    public string certOf { get; set; }
}

public class BORN10
{
    public string certOf { get; set; }
}

public class MARRIED17
{
    public string certOf { get; set; }
}

public class CREATE
{
    public DAUGHTER2 DAUGHTER { get; set; }
    public HUSBAND2 HUSBAND { get; set; }
    public FATHER2 FATHER { get; set; }
    public BROTHER2 BROTHER { get; set; }
    public WIFE2 WIFE { get; set; }
    public SON2 SON { get; set; }
    public MOTHER2 MOTHER { get; set; }
    public SISTER2 SISTER { get; set; }
}

public class DAUGHTER2
{
    public BORN11 BORN { get; set; }
}

public class BORN11
{
    public string certOf { get; set; }
}

public class HUSBAND2
{
    public MARRIED18 MARRIED { get; set; }
}

public class MARRIED18
{
    public string certOf { get; set; }
}

public class FATHER2
{
    public BORN12 BORN { get; set; }
}

public class BORN12
{
    public string certOf { get; set; }
}

public class BROTHER2
{
    public BORN13 BORN { get; set; }
}

public class BORN13
{
    public string certOf { get; set; }
}

public class WIFE2
{
    public MARRIED19 MARRIED { get; set; }
}

public class MARRIED19
{
    public string certOf { get; set; }
}

public class SON2
{
    public BORN14 BORN { get; set; }
}

public class BORN14
{
    public string certOf { get; set; }
}

public class MOTHER2
{
    public BORN BORN { get; set; }
}

public class BORN15
{
    public string certOf { get; set; }
}

public class SISTER2
{
    public BORN16 BORN { get; set; }
}

public class BORN16
{
    public string certOf { get; set; }
}

public class Detail
{
    public int id { get; set; }
    public string traversal { get; set; }
    public string certTraversal { get; set; }
    public string pnfl { get; set; }
    public string surname { get; set; }
    public string name { get; set; }
    public string patronym { get; set; }
    public string birthDate { get; set; }
    public string gender { get; set; }
    public string _event { get; set; }
    public object deactivateEvent { get; set; }
    public int branch { get; set; }
    public string certSeries { get; set; }
    public string certNumber { get; set; }
    public string certDate { get; set; }
    public object taskSubstate { get; set; }
    public object taskSubmessage { get; set; }
    public bool active { get; set; }
    public string action { get; set; }
    public string stages { get; set; }
    public int memberNum { get; set; }
}
