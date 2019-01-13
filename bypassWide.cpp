// just bypass wide
void bfs(int u) {
  bool used[u];
  int p[u] = u;
  int dist[u];
  queue<int> q; // TO DO: implement
  q.push(u);
  while (!q.empty()) {
    int u = q.front();
    q.pop();
    for (int i = 0; i < (int) g[u].size(); i++) {
      int v = g[u][i];
      if (!used[v]) {
        used[v] = true;
        p[v] = u;
        dist[v] = dist[u] + 1;
        q.push(v);
      }
    }
  }
}
// where:
// g - list of adjacent vertices
// used - list of vertices traversed
// q - temp queue
// p - array of ancestors
