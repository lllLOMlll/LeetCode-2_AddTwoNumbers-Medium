using System.Numerics;
using System.Windows.Markup;

public class Solution
{

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode current1 = l1;
        ListNode current2 = l2;

        List<int> numsListInNode1 = new List<int>();
        List<int> invertNumsListInNode1 = new List<int>();
        string invertNumsListInNode1String = "";

        List<int> numsListInNode2 = new List<int>();
        List<int> invertNumsListInNode2 = new List<int>();
        string invertNumsListInNode2String = "";

        // Getting the numbers into a list
        while (current1 != null)
        {
            numsListInNode1.Add(current1.val);
            current1 = current1.next;
        }


        while (current2 != null)
        {
            numsListInNode2.Add(current2.val);
            current2 = current2.next;
        }

        // Reverting the numbers
        int lastIndexofnumsListNode1 = numsListInNode1.Count - 1; // Count - 1 = last index
        for (int i = lastIndexofnumsListNode1; i > -1; i--)
        {
            invertNumsListInNode1.Add(numsListInNode1[i]);
            invertNumsListInNode1String += numsListInNode1[i];
        }

        int lastIndexofnumsListNode2 = numsListInNode2.Count - 1; // Count - 1 = last index
        for (int i = lastIndexofnumsListNode2; i > -1; i--)
        {
            invertNumsListInNode2.Add(numsListInNode2[i]);
            invertNumsListInNode2String += numsListInNode2[i];
        }

        // Parsing the string to int
        long invertNumsListInNode1Int = long.Parse(invertNumsListInNode1String);
        long invertNumsListInNode2SInt = long.Parse(invertNumsListInNode2String);

        // Getting the total
        long total = invertNumsListInNode1Int + invertNumsListInNode2SInt;

        // Reversing the total
        string totalString = total.ToString();
        string invertTotalString = "";
        for (int i = totalString.Length - 1; i > -1; i--)
        {
            invertTotalString += totalString[i];
        }

        // Getting the final result into a list
        List<int> finalResult = new List<int>();
        for (int i = 0; i < invertTotalString.Length; i++)
        {
            finalResult.Add(int.Parse(invertTotalString[i].ToString()));
        }

        ListNode head = new ListNode(finalResult[0]);
        ListNode current = head;
        for (int i = 1; i < invertTotalString.Length; i++)
        {
            current.next = new ListNode(finalResult[i]);
            current = current.next;
        }

        Console.WriteLine(string.Join(", ", numsListInNode1));
        Console.WriteLine(string.Join(", ", invertNumsListInNode1));
        Console.WriteLine(invertNumsListInNode1String);
        Console.WriteLine(invertNumsListInNode2String);
        Console.WriteLine(total);
        Console.WriteLine(invertTotalString);
        Console.WriteLine(string.Join(", ", finalResult));


        return head;

    }
    public static void AfficherListe(ListNode head)
    {
        ListNode current = head;
        while (current != null)
        {
            Console.Write(current.val + " -> ");
            current = current.next;
        }
        Console.WriteLine("null");
    }

    static void Main(string[] args)
    {
        Solution s = new Solution();

        ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
        ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));

        //AfficherListe(l1);
        Console.WriteLine();
        AfficherListe(s.AddTwoNumbers(l1, l2));


        ListNode l1_4 = new ListNode(9);
        ListNode l2_4 = new ListNode(1,
                      new ListNode(9,
                      new ListNode(9,
                      new ListNode(9,
                      new ListNode(9,
                      new ListNode(9,
                      new ListNode(9,
                      new ListNode(9,
                      new ListNode(9,
                      new ListNode(9))))))))));
    

        AfficherListe(s.AddTwoNumbers(l1_4, l2_4));

    }
}
