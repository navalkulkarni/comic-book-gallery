# comic-book-gallery
sample project of a comic book gallery to better understand concepts of .NET MVC

<h3>Learnings Made From Doing this Project</h3>
<ul>
  <li>Controller Classes and Action Methods Need to be Public</li>
  <li>You must end names of controller classes with <em>Controller</em> word</li>
  <li><p>MVC finds our Controller and Action Method by URL Routing
	When we run the project locally URL is generated as follows :
	 http://localhost:<random port number>
	 At this point, MVC is looking for a HomeController and an Action Method
	 Named Index.</p><p>
	 If it can't find these two, it will give a 404 NOT FOUND Error.
	 Until this point in the project I have added a ComicBooksController
	 and a method named Detail.
	 So, if we write the URL as http://localhost:<port number>/ComicBooks/Detail,
	 You will get the response string as mentioned in the return of Detail Method.
  </p></li>

</ul>
