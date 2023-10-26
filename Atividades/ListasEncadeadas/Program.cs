using  LinkedList;
Page pageFirst = new Page() { Content = "Atualmente...", PageNumber = 1};
Page pageSecond = new Page() { Content = "Aplicação...", PageNumber = 2};
Page pageThird = new Page() { Content = "Muito de...", PageNumber = 3};
Page pageFourth = new Page() { Content = "Você sabia...", PageNumber = 4};
Page pageFifth = new Page() { Content = "Enquanto...", PageNumber = 5};
Page pageSixth = new Page() { Content = "Você poderia..." , PageNumber = 6};
Page pageSeventh = new Page() { Content = "Era uma vez...", PageNumber = 7};

LinkedList<Page> pages = new LinkedList<Page>();
pages.AddLast(pageSecond);
LinkedListNode<Page> nodePageFourth = pages.AddLast(pageFourth); 
pages.AddLast(pageSixth);
pages.AddFirst(pageFirst);

pages.AddBefore(nodePageFourth, pageThird);
pages.AddAfter(nodePageFourth, pageFifth);
