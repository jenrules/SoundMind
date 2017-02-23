$(function() {
    $("#search").on("click", function() {
    	var searchTerm = $("#searchTerm").val();
		var url = "https://itunes.apple.com/search?limit=5&term="+ searchTerm;
		$.ajax({
			url: url,
			type: 'get',
			contentType: "jsonp",
			async: false,
        	dataType: "jsonp",
        	success: function(songs) {
            $("#output").html();
        		for (var i = 0; i < songs.results.length; i++){
        			$("#output").append("<div><img src=" + songs.results[i].artworkUrl100 + "><h2>" + songs.results[i].trackName + "</h2>" + "<p>" + songs.results[i].artistName + "</p><audio controls><source src='" + songs.results[i].previewUrl + "'type=" + "audio/mp4>" + "</audio>" + "</a></div></div>");
            }
          }
       })
    });
  });
