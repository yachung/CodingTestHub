#include <iostream>
#include <vector>
#include <queue>

using namespace std;

struct Point {
    int row, col, dist;
    Point(int r, int c, int d) : row(r), col(c), dist(d) {}
};

int solution(vector<vector<int>> maps) {
    int n = maps.size();
    int m = maps[0].size();

    // 방문 여부를 나타내는 배열
    vector<vector<bool>> visited(n, vector<bool>(m, false));

    // 상하좌우 이동을 위한 배열
    vector<pair<int, int>> directions = { {1, 0}, {-1, 0}, {0, 1}, {0, -1} };

    // 시작점 (1, 1)에서 출발
    queue<Point> q;
    q.push(Point(0, 0, 1));
    visited[0][0] = true;

    while (!q.empty()) {
        Point current = q.front();
        q.pop();

        // 목적지에 도착한 경우 최단 거리 반환
        if (current.row == n - 1 && current.col == m - 1) {
            return current.dist;
        }

        // 상하좌우 이동
        for (pair<int, int> dir : directions) {
            int nR = current.row + dir.first;
            int nC = current.col + dir.second;

            // 다음 위치가 유효하고 이동할 수 있는 칸이며 방문하지 않았다면 큐에 추가
            if (nR >= 0 && nR < n && nC >= 0 && nC < m &&
                maps[nR][nC] == 1 && !visited[nR][nC]) {
                q.push(Point(nR, nC, current.dist + 1));
                visited[nR][nC] = true;
            }
        }
    }

    // 도착할 수 없는 경우 -1 반환
    return -1;
}