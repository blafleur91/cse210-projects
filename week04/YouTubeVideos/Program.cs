using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        List<Video> _videos = new List<Video>();

        // I believe that for me making the video, I have to put the info in the parantheses for the new Video.
        // since it is not red I believe it is correct.
        Video videoOne = new Video("Title Filler One", "Author Filler One", 123);
        videoOne.VideoComments("Filler Comment Name One", "Filler Comment Text One");
        videoOne.VideoComments("Filler Comment Name Two", "Filler Comment Text Two");
        videoOne.VideoComments("Filler Comment Name Three", "Filler Comment Text Three");

        _videos.Add(videoOne);

        Video videoTwo = new Video("Title Filler Two", "Author Filler Two", 456);
        videoTwo.VideoComments("Filler Comment Name One", "Filler Comment Text One");
        videoTwo.VideoComments("Filler Comment Name Two", "Filler Comment Text Two");
        videoTwo.VideoComments("Filler Comment Name Three", "Filler Comment Text Three");
        videoTwo.VideoComments("Filler Comment Name Four", "Filler Comment Text Four");

        _videos.Add(videoTwo);

        Video videoThree = new Video("Title Filler Three", "Author Filler Three", 789);
        videoThree.VideoComments("Filler Comment Name One","Filler Comment Text One");
        videoThree.VideoComments("Filler Comment Name Two","Filler Comment Text Two");
        videoThree.VideoComments("Filler Comment Name Three","Filler Comment Text Three");

        _videos.Add(videoThree);


        // this foreach loop (they work like for loops in python) will pull from a list of videos from the Video class.
        // meaning the list is made out of Video Objexcts (boxes). Then for each video pulled it will call the DisplayVideo method
        // (methods are just functions but are unique to a class). The DisplayVideo method will display the videos Title, Author, and
        // length in seconds. then the loop calls the DisplayVideoComments method, which will call on a list of comments. That list
        // then goes through a for each loop and calls the commentName and commentText variables and display them.
        foreach (var video in _videos)
        {
            Console.WriteLine(video.DisplayVideo());
            video.DisplayVideoComments();
            Console.WriteLine();
        }
        
    }
}