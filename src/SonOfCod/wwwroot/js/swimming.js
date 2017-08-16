var width = 450,
    height = 280;

var n = 90,
    m = 16,
    degrees = 180 / Math.PI;

var minnows = d3.range(n).map(function() {
    var x = Math.random() * width,
        y = Math.random() * height;
    return {
        vx: Math.random() * 2 - 1,
        vy: Math.random() * 2 - 1,
        path: d3.range(m).map(function() { return [x, y]; }),
        count: 0
    };
});

var svg = d3.select("body").append("svg")
    .attr("width", width)
    .attr("height", height);

var g = svg.selectAll("g")
    .data(minnows)
  .enter().append("g");

var head = g.append("ellipse")
    .attr("rx", 8)
    .attr("ry", 2);

var sideHead = g.append("ellipse")
    .attr("rx", 1)
    .attr("ry", 10);

g.append("path")
    .datum(function(d) { return d.path.slice(0, 3); })
    .attr("class", "mid");

g.append("path")
    .datum(function(d) { return d.path; })
    .attr("class", "tail");

var tail = g.selectAll("path");

d3.timer(function() {
    for (var i = -1; ++i < n;) {
        var minnowZoom = minnows[i],
            path = minnowZoom.path,
            dx = minnowZoom.vx,
            dy = minnowZoom.vy,
            x = path[0][0] += dx,
            y = path[0][1] += dy,
            speed = Math.sqrt(dx * dx + dy * dy),
            count = speed / 1.2,
            k1 = -1.3 - speed / 9;

        // Bounce off the walls.
        if (x < 0 || x > width) minnowZoom.vx *= -1;
        if (y < 0 || y > height) minnowZoom.vy *= -1;

        // Swim!
        for (var j = 0; ++j < m;) {
            var vx = x - path[j][0],
                vy = y - path[j][1],
                k2 = Math.sin(((minnowZoom.count += count) + j * 3) / 100) / speed;
            path[j][0] = (x += dx / speed * k1) - dy * k2;
            path[j][1] = (y += dy / speed * k1) + dx * k2;
            speed = Math.sqrt((dx = vx) * dx + (dy = vy) * dy);
        }
    }

    head.attr("transform", headTransform);
    sideHead.attr("transform", sideHeadTransform);
    tail.attr("d", tailPath);
});

function headTransform(d) {
    return "translate(" + d.path[0] + ")rotate(" + Math.atan2(d.vy, d.vx) * degrees + ")";
}

function sideHeadTransform(d) {
    return "translate(" + d.path[0] + ")rotate(" + Math.atan2(d.vy, d.vx) / degrees + ")";
}

function tailPath(d) {
    return "M" + d.join("L");
}
