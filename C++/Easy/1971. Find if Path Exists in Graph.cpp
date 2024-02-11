#include <vector>
#include <unordered_set>

using namespace std;

class Solution {
private:
    unordered_map<int, int> parent;
    unordered_map<int, int> size;

    void make(int node) {
        parent[node] = node;
        size[node] = 1;
    }

    int find(int node) {
        if (node == parent[node]) {
            return node;
        }
        size[parent[node]] -= size[node];
        return parent[node] = find(parent[node]);
    }

    void Union(int a, int b) {
        a = find(a);
        b = find(b);
        if (a == b) {
            return;
        }
        if (size[a] < size[b]) {
            swap(a, b);
        }
        parent[b] = a;
        size[a] += size[b];
    }

public:
    Solution() {
        cin.tie(NULL);
        cout.tie(NULL);
        ios_base::sync_with_stdio(false);
    }

    bool validPath(int n, vector<vector<int>>& edges, int source, int destination) {
        for (int i = 0; i < n; i++) {
            make(i);
        }

        for (const auto& edge : edges) {
            Union(edge.front(), edge.back());
        }

        return find(source) == find(destination);
    }
};
